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
    public class P3
    {
        public double x;
        public double y;
        public double z;
        public P3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public P3()
        {

        }

        public double dist(P3 r)
        {
            return Math.Sqrt((x - r.x) * (x - r.x) + (y - r.y) * (y - r.y) + (z - r.z) * (z - r.z));
        }

        public P3 Add(P3 vec)
        {
            P3 results = new P3();
            results.x = this.x + vec.x;
            results.y = this.y + vec.y;
            results.z = this.z + vec.z;
            return results;
        }
        public P3 Sub(P3 vec)
        {
            P3 results = new P3();
            results.x = this.x - vec.x;
            results.y = this.y - vec.y;
            results.z = this.z - vec.z;
            return results;
        }
        public P3 Scale(P3 scale)
        {
            P3 results = new P3();
            results.x = this.x * scale.x;
            results.y = this.y * scale.y;
            results.z = this.z * scale.z;
            return results;
        }

        public P3 Scale(double f)
        {
            P3 results = new P3();
            results.x = this.x * f;
            results.y = this.y * f;
            results.z = this.z * f;
            return results;
        }

        public double Length()
        {
            double results = this.x * this.x;
            results += this.y * this.y;
            results += this.z * this.z;
            return Math.Sqrt(results);
        }

        public P3 Normalize()
        {
            P3 results = new P3();
            double len = this.Length();
            results.x = this.x / len;
            results.y = this.y / len;
            results.z = this.z / len;
            return results;
        }
        public double DProduct(P3 vec) //angle between vectors (returns cos of angle)
        {
            double results = this.x * vec.x;
            results += this.y * vec.y;
            results += this.z * vec.z;
            return results;
        }
        public P3 CProduct(P3 vec) //vector perpendicular to given vectors
        {
            P3 results = new P3();
            results.x = this.y * vec.z - this.z * vec.y;
            results.y = this.z * vec.x - this.x * vec.z;
            results.z = this.x * vec.y - this.y * vec.x;
            return results;
        }
        public P3 fromSpherical(double theta, double phi)
        {
            P3 results = new P3();
            results.x = Math.Sin(theta) * Math.Cos(phi);
            results.y = Math.Sin(theta) * Math.Sin(phi);
            results.z = Math.Cos(theta);
            return results;
        }
    }
}
