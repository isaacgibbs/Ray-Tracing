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
    public class Ray
    {
        public P3 origin;
        public P3 vec;
        public RColor color;
        public Ray(P3 p, P3 direction)
        {
            this.origin = p;
            this.vec = direction;
            this.color = new RColor(0,0,0);
            if (vec.Length() > 1.0)
            {
                vec = vec.Normalize();

            }
        }
        public P3 travel(double time)
        {
            P3 results = new P3();
            if (vec.Length() > 1.0)
            {
                vec = vec.Normalize();

            }
            results.x = this.origin.x + (this.vec.x * time);
            results.y = this.origin.y + (this.vec.y * time);
            results.z = this.origin.z + (this.vec.z * time);
            return results;        
        }
    }
}
