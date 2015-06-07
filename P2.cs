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
    public class P2
    {
        public double x;
        public double y;
        public P2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public P2()
        {

        }

        public P2 Add(P2 vec)
        {
            P2 results = new P2();
            results.x = this.x + vec.x;
            results.y = this.y + vec.y;
            return results;
        }
        public P2 Sub(P2 vec)
        {
            P2 results = new P2();
            results.x = this.x - vec.x;
            results.y = this.y - vec.y;
            return results;
        }
        public P2 Scale(P2 scale)
        {
            P2 results = new P2();
            results.x = this.x * scale.x;
            results.y = this.y * scale.y;
            return results;
        }

        public double Length()
        {
            double results = this.x * this.x;
            results += this.y * this.y;
            return Math.Sqrt(results);
        }

        public P2 Normalize()
        {
            P2 results = new P2();
            double len = this.Length();
            results.x = this.x / len;
            results.y = this.y / len;
            return results;
        }
    }
}
