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
    public interface Skin  //asks about geometry normal to decide ray interaction
    {
        RColor color(P3 p, Ray r, SceneObject so); //color seen by ray hitting point r with texture and skin
    }
}
