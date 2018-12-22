using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_TwoClasses
{
    class Colors
    {
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }
        private byte alpha;

        public byte Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }
 
        public Colors(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.Alpha = alpha;
        }

        public Colors(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.Alpha = 255;
        }

        public byte Grayscale()
        {
            return (byte)((green + red + blue) / 3);
        }

    }
}
