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
    public interface Texture
    {
        RColor texture(P2 p);
    }
}

//dot product for light in non-reflective skin

//Start with multiple spheres. One in front of another
//New geometry (plane)
//texturing (from jpg)
//image pixelAt, width, and height methods
    //centered square to convert to geometry points
