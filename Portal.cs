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
    class Portal : Skin
    {
        public Disc linked;
        Rotations rot;
        public P3 dist;
        public Portal(Disc d)
        {
            linked = d;
            rot = new Rotations();
        }
        public RColor color(P3 p, Ray r, SceneObject so)
        {
            RColor results = new RColor(0, 0, 0);
            dist = so.geometry.location().Sub(linked.location());
            P3 svec = linked.normal(p);
            double c1 = -svec.DProduct(r.vec);
            P3 temp = svec.Scale(c1 * 2).Add(r.vec);
            //P3 degrees = so.normal(p).DProduct(linked.N);
            P3 newpoint = so.geometry.location().Sub(p);
            newpoint = linked.location().Add(newpoint);
            p = p.Add(dist);
            Ray ray = new Ray(p, r.vec); //need to translate and rotate p to shoot appropriately from linked
            results = results.Add(Form1.shootRay(ray));
            return results;
        }
    }
}
