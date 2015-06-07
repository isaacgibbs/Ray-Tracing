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
    class ImageTexture : Texture
    {
        Bitmap image;
        public int width;
        public int height;
        public ImageTexture(Bitmap image)
        {
            this.image = new Bitmap(image);
            this.width = image.Width;
            this.height = image.Height;
        }
        public RColor texture(P2 p)
        {
            RColor c = new RColor(0, 0, 0);
            int x = (int)(p.x * this.width);
            int y = (int)(p.y * this.height);
            Color clr = image.GetPixel(x, y);
            c.r = clr.R;
            c.g = clr.G;
            c.b = clr.B;

            c = c.Scale((float)0.003921568627451);
            return c;
        }
    }
}
