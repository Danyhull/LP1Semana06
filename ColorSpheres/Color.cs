using System;
using System.Drawing;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte r;
        private readonly byte g;
        private readonly byte b;
        private readonly byte a;

        private byte alphamax = 255;
        public Color (byte red, byte green, byte blue, byte alpha)
        {
            r = red;
            g = green;
            b = blue;
            a = alpha;
        }
        public byte getred()
        {
            return r;
        }
        public byte getgreen()
        {
            return g;
        }
        public byte getblue()
        {
            return b;
        }
        public byte  getalpha()
        {
            return a;
        }
        public byte getgrey()
        {
            int media = (r+g+b)/3;
            byte grey = (byte)media;
            return grey;
        }
        
        
    }
}