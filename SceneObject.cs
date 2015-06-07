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
    public class SceneObject
    {
        public Geometry geometry;
        public Texture texture;
        public Skin skin;
        public SceneObject(Geometry shape, Texture texture, Skin skin)
        {
            this.geometry = shape;
            this.texture = texture;
            this.skin = skin;
        }
        public SceneObject()
        {
        }
        public double distance(Ray r)
        {
            return geometry.intersect(r);
        }
        public P3 normal(P3 vec)
        {
            return geometry.normal(vec);
        }
        public RColor color(P3 p, Ray ray)
        {
            return skin.color(p, ray, this);
        }
        public P2 toP2(P3 p)
        {
            return geometry.toP2(p);
        }
    }
}
