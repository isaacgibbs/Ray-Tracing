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
    public class NonReflective : Skin
    {
        public NonReflective()
        {
        }
        public RColor color(P3 p, Ray r, SceneObject so) 
        {
            RColor results = new RColor(0, 0, 0);
            P3 svec;
            svec = so.normal(p);
            for (int i = 0; i < Form1.globals.lights.Count; i++)
            {
                Ray ray = new Ray(p, Form1.globals.lights[i].Direction.Scale(-1));
                if (!Form1.rayBlocked(ray) || Form1.globals.lights[i].Direction.Length() == 0)  //allows if not blocked or ambient light
                {
                    results = results.Add(Form1.globals.lights[i].illumination(p, svec));
                }
            }
            results = results.Scale(so.texture.texture(so.geometry.toP2(p)));
            return results;
        }
    }
}
