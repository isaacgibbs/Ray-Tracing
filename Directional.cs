/*
    Isaac A. Gibbs
    4/24/2014
    Ray Tracing
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray_Tracing
{
    class Directional : Light
    {
        public P3 direction;
        public RColor color;
        public Directional(P3 d, RColor c)
        {
            this.direction = d;
            this.color = c;
        }
        public RColor illumination(P3 p, P3 normal)
        {
            RColor result = new RColor(0, 0, 0);

                float shade = (float)direction.DProduct(normal);
                if (shade < 0)
                    shade = 0;
                result = color.Scale(shade);
            return result;
        }
        public P3 Direction
        {
            get
            {
                return this.direction;
            }
        }
    }
}
