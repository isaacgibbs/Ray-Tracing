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
    class SolidTexture : Texture
    {
        RColor color;
        public SolidTexture(RColor color)
        {
            this.color = color;
        }
        public RColor texture(P2 p)
        {
            return this.color;
        }
    }
}
