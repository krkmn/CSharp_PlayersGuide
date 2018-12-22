using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_TwoClasses
{
    class Colors
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Colors(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Colors(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public void SetRed(byte red)
        {
            this.red = red;
        }

        public byte GetRed()
        {
            return red;
        }

        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public byte GetGreen()
        {
            return green;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public byte Grayscale()
        {
            return (byte)((green + red + blue) / 3);
        }

    }
}
