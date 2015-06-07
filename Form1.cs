using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ray_Tracing
{
    public partial class Form1 : Form
    {
        public static Globals globals;
        public Form1()
        {
            InitializeComponent();
            initializeProgram();
        }

        public void initializeProgram()
        {
            globals = new Globals();
            globals.pixelArray = new int[2] { screen.Width, screen.Height };
            globals.rays = new Ray[globals.pixelArray[0], globals.pixelArray[1]];
            addTexturedShape("Earth_Texture.jpg", new Sphere(new P3(-0.25, 0.8, 0.05), 0.3));
            addTexturedShape("Moon_Texture.jpg", new Sphere(new P3(0.25, 0.2, -0.1), 0.1));
            Disc portal1 = new Disc(new P3(1, 1.0, 0), new P3(0.6, 1, 0).Normalize(), 0.2);
            Disc portal2 = new Disc(new P3(-0.8, 1.2, 0), new P3(-0.5, 1, 0).Normalize(), 0.2);

            globals.objects.Add(new SceneObject(new Plane(new P3(0, 0, 0.5), new P3(0, 0, 1).Normalize()), new SolidTexture(new RColor(1.0f, 0, 0)), new NonReflective()));
            globals.objects.Add(new SceneObject(new Plane(new P3(0, 2.0, 0), new P3(-0.5, 1, 0).Normalize()), new SolidTexture(new RColor(0.5f, 0.5f, 0.5f)), new NonReflective()));
            globals.objects.Add(new SceneObject(new Plane(new P3(0, 2.0, 0), new P3(0.6, 1, 0).Normalize()), new SolidTexture(new RColor(0.5f, 0.5f, 0.5f)), new NonReflective()));
            globals.objects.Add(new SceneObject(portal1, new SolidTexture(new RColor(0.0f, 1.0f, 0.0f)), new Portal(portal2)));
            globals.objects.Add(new SceneObject(portal2, new SolidTexture(new RColor(0.0f, 1.0f, 0.0f)), new Portal(portal1)));
            raysToSphere();
            normalizeColors();
        }

        public void raysToSphere()
        {
            for (int i = 0; i < globals.pixelArray[0]; i++)
            {
                for (int j = 0; j < globals.pixelArray[1]; j++)
                {
                    P3 screenpoint = new P3(i / (float)globals.pixelArray[0] * 2 - 1, 0, j / (float)globals.pixelArray[1] * 2 - 1);
                    globals.rays[i, j] = new Ray(globals.camera, screenpoint.Sub(globals.camera));
                    globals.rays[i, j].color = shootRay(globals.rays[i, j]);
                }
            }
        }

        public static RColor shootRay(Ray ray)
        {
            RColor results = new RColor(0, 0, 0);
            double time = -1;
            int shapeindex = 0;
            for (int x = 0; x < globals.objects.Count; x++)
            {
                double temp = globals.objects[x].distance(ray);
                if (temp > 0.001)
                {
                    double shit = globals.objects[x].distance(ray);
                }
                if (temp != -1 && temp > 0.001)
                {
                    if (time == -1)
                    {
                        time = temp;
                        shapeindex = x;
                    }
                    else if (temp < time)
                    {
                        time = temp;
                        shapeindex = x;
                    }
                }
            }
            if (time != -1)
            {
                P3 spoint = new P3();           
                spoint = ray.travel(time);
                results = globals.objects[shapeindex].color(spoint, ray);
            }
            return results;
        }

        public static bool rayBlocked(Ray ray)
        {
            bool results = false;
            double time = -1;
            for (int x = 0; x < globals.objects.Count; x++)
            {
                double temp = globals.objects[x].distance(ray);
                if (temp != -1 && temp > 0.001)
                {
                    if (time == -1)
                    {
                        time = temp;
                    }
                    else if (temp < time)
                    {
                        time = temp;
                    }
                }
            }
            if (time != -1)
            {
                return true;
            }
            return results;
        }

        public void normalizeColors()
        {
            float maxintensity = 0;
            float exp = 0;
            for (int i = 0; i < globals.pixelArray[0]; i++)
            {
                for (int j = 0; j < globals.pixelArray[1]; j++)
                {
                    float temp = globals.rays[i, j].color.Intensity();
                    if(temp > maxintensity)
                    {
                        maxintensity = temp;
                    }
                }
            }
            exp = (1 / maxintensity) * globals.exposure;
            for (int i = 0; i < globals.pixelArray[0]; i++)
            {
                for (int j = 0; j < globals.pixelArray[1]; j++)
                {
                    globals.rays[i, j].color = globals.rays[i, j].color.Scale(exp);
                }
            }
        }

        public void drawScene(Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.Black);
            double scalex = screen.Width / globals.pixelArray[0];
            double scaley = screen.Height / globals.pixelArray[1];
            for (int i = 0; i < globals.pixelArray[0]; i++)
            {
                for (int j = 0; j < globals.pixelArray[1]; j++)
                {
                        b = new SolidBrush(globals.rays[i, j].color.ToRGB());
                        g.FillRectangle(b, i, j, 1, 1);
                }
            }
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            drawScene(g);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            globals.camera.y = hScrollBar1.Value;
        }

        private void addTexturedShape(String filename, Geometry obj)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Ray_Tracing." + filename);
            Bitmap image = new Bitmap(myStream);
            globals.textures.Add(image);
            globals.objects.Add(new SceneObject(obj, new ImageTexture(globals.textures[globals.textures.Count - 1]), new NonReflective()));
            //globals.objects.Add(new SceneObject(new Sphere(new P3(0, 1, 0), 1), new ImageTexture(globals.textures[0]), new NonReflective()));
        }

    }
}
