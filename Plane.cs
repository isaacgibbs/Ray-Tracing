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
    class Plane : Geometry
    {
        P3 P;
        P3 N;
        double d;
        public Plane(P3 p, P3 normal)
        {
            this.P = p;
            this.N = normal;
            d = -1 * (normal.DProduct(p));
        }
        public double intersect(Ray ray)
        {
            double den = ray.vec.DProduct(N);
            if (den == 0) return -1;
            double t = -(d + N.DProduct(ray.origin)) / den;
            if (t < 0) return -1;
            return t;
        }
        public P3 normal(P3 p)
        {
            return this.N;
        }
        public P2 toP2(P3 p)
        {
            P3 xa = new P3(1, 0, 0);
            P3 ya = new P3(0, 1, 0);
            return new P2((float)p.DProduct(xa), (float)p.DProduct(ya));
        }
        public P3 location()
        {
            return this.P;
        }
    }
}
