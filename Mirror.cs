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
    class Mirror : Skin
    {
        public Mirror()
        {
        }
        public RColor color(P3 p, Ray r, SceneObject so)
        {
            RColor results = new RColor(0, 0, 0);
            P3 svec = so.normal(p);
            double c1 = -svec.DProduct(r.vec);
            P3 temp = svec.Scale(c1 * 2).Add(r.vec);
            Ray ray = new Ray(p, temp);
            results = results.Add(Form1.shootRay(ray));
            /*for (int i = 0; i < Form1.globals.lights.Count; i++)
            {
                ray = new Ray(p, Form1.globals.lights[i].Direction.Scale(-1));
                if (!Form1.rayBlocked(ray) || Form1.globals.lights[i].Direction.Length() == 0) //allows if not blocked or ambient light
                {
                    results = results.Add(Form1.globals.lights[i].illumination(p, svec));
                }
            }*/
            //results = results.Scale(so.texture.texture(so.geometry.toP2(p)));
            return results;
        }
    }
}
