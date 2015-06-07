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
    public class Sphere : Geometry
    {
        public P3 origin;
        public double radius;

        public Sphere(P3 center, double radius)
        {
            this.origin = center;
            this.radius = radius;
        }

        public P2 toP2(P3 p)
        {
            P3 vn = new P3(0,0,1);
            P3 ve = new P3(1,0,0);
            P3 vp;
            vp = p.Sub(origin).Normalize();
            double phi = Math.Acos(-vn.DProduct(vp));
            double v = phi / Math.PI;
            double theta = Math.Acos(vp.DProduct(ve) / Math.Sin(phi)) / (2 * Math.PI);
            double u;
            if (vp.DProduct(vn.CProduct(ve)) > 0)
            {
                u = theta;
            }
            else
            {
                u = 1 - theta;
            }
            return new P2(u, v);
        }

        public double intersect(Ray ray)
        {
            P3 eo = origin.Sub(ray.origin);
            float vec = (float)eo.DProduct(ray.vec);
            float discriminate = (float)((radius * radius) - (eo.DProduct(eo) - (vec * vec)));
            if (discriminate < 0)
            {
                return -1;
            }
            else
            {
                float d = (float)Math.Sqrt(discriminate);
                if ((vec - d) > 0)
                {
                    return vec - d;
                }
                else if ((vec - d) < 0 && (vec + d) < 0)
                {
                    return -1;
                }
                else return vec + d;
            }
        }

        public P3 normal(P3 p)
        {
            P3 results = new P3();
            /*double temp = vec.Length() - this.origin.Length();
            results = vec.Sub(this.origin).Scale(new P3(temp, temp, temp));*/
            results = this.origin.Sub(p).Scale(1/radius); 
            return results;
        }
        public P3 location()
        {
            return this.origin;
        }

    }
}
