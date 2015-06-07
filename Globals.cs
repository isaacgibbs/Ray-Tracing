/*
    Isaac A. Gibbs
    4/24/2014
    Ray Tracing
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    public class Globals
    {
        public double theta;
        public double phi;
        public int[] pixelArray;
        public P3 camera;
        public List<SceneObject> objects;
        public List<Light> lights;
        public Ray[,] rays;
        public double[,] intersecttimes;
        public P3 light;
        public double time;
        public List<Bitmap> textures;
        public float exposure;
        public Globals()
        {
            exposure = 1.0f;
            theta = 180;
            phi = 180;
            camera = new P3(0.1, -5, -0.9);
            textures = new List<Bitmap>();
            lights = new List<Light>();
            lights.Add(new Directional(new P3(-0.6, 0.6, 0.3).Normalize(), new RColor(1.0f, 1.0f, 1.0f)));
            //lights.Add(new Directional(new P3(0.4, -0.5, -0.2).Normalize(), new RColor(1.0f, 1.0f, 1.0f)));
            lights.Add(new Ambient(new RColor(0.4f, 0.4f, 0.4f)));
            objects = new List<SceneObject>();
            light = new P3().fromSpherical(theta, phi);
        }
    }
}
