using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_TwoClasses
{
    class Colors
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Colors(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Colors(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public void SetRed(int red)
        {
            this.red = red;
        }

        public int GetRed()
        {
            return red;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }

        public int GetGreen()
        {
            return green;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public int GetBlue()
        {
            return blue;
        }

        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

        public int GetAlpha()
        {
            return alpha;
        }

        public int Grayscale()
        {
            return (green + red + blue) / 3;
        }

    }
}
