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
    class Ambient : Light
    {
        RColor color;
        P3 direction;
        public Ambient(RColor c)
        {
            this.color = c;
            direction = new P3(0, 0, 0);
        }
        public RColor illumination(P3 p, P3 normal)
        {
            RColor result = new RColor();
            result = this.color;
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
