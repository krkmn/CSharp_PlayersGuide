using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_TwoClasses
{
    class Balls
    {
        public int size;
        private Colors color;
        public int throws;

        public Balls(int size, Colors color)
        {
            this.size = size;
            this.color = color;
        }

        public void Throw()
        {
            if (size != 0)
            {
                throws += 1;
            }
        }

        public void Pop()
        {
            size = 0;
        }


    }
}
