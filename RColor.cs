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
using System.Drawing;

namespace Ray_Tracing
{
    public class RColor
    {
        public float r;
        public float g;
        public float b;

        public RColor(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public RColor()
        {
        }

        public RColor Scale(RColor scale)
        {
            RColor results = new RColor();
            results.r = this.r * scale.r;
            results.g = this.g * scale.g;
            results.b = this.b * scale.b;
            return results;
        }

        public RColor Scale(P3 scale)
        {
            RColor results = new RColor();
            results.r = this.r * (float)scale.x;
            results.g = this.g * (float)scale.y;
            results.b = this.b * (float)scale.z;
            return results;
        }

        public RColor Scale(float d)
        {
            RColor results = new RColor();
            results.r = this.r * d;
            results.g = this.g * d;
            results.b = this.b * d;
            return results;
        }

        public RColor Add(RColor vec)
        {
            RColor results = new RColor();
            results.r = this.r + vec.r;
            results.g = this.g + vec.g;
            results.b = this.b + vec.b;
            return results;
        }

        public RColor Add(P3 vec)
        {
            RColor results = new RColor();
            results.r = this.r + (float)vec.x;
            results.g = this.g + (float)vec.y;
            results.b = this.b + (float)vec.z;
            return results;
        }

        public RColor Sub(RColor vec)
        {
            RColor results = new RColor();
            results.r = this.r - vec.r;
            results.g = this.g - vec.g;
            results.b = this.b - vec.b;
            return results;
        }

        public RColor Sub(P3 vec)
        {
            RColor results = new RColor();
            results.r = this.r - (float)vec.x;
            results.g = this.g - (float)vec.y;
            results.b = this.b - (float)vec.z;
            return results;
        }

        public float Intensity()
        {
            float results = this.r * this.r;
            results += this.g * this.g;
            results += this.b * this.b;
            return (float)Math.Sqrt(results);
        }

        public RColor NormalizeIntensity()
        {
            RColor results = new RColor();
            float len = this.Intensity();
            results.r = this.r / len;
            results.g = this.g / len;
            results.b = this.b / len;
            return results;
        }

        public Color ToRGB()
        {
            return Color.FromArgb(Math.Min((int)(r * 255), 255), Math.Min((int)(g * 255), 255), Math.Min((int)(b * 255), 255));
        }
    }
}
