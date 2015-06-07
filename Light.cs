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
    public interface Light
    {
        P3 Direction {get;}
        RColor illumination(P3 p, P3 normal); //returns total light(color) striking surface of scene object
    }
}
