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
    public interface Geometry
    {
        double intersect(Ray ray);
        P3 normal(P3 vec); //plane is point and normal vector
        P2 toP2(P3 p);
        P3 location();
    }
}
