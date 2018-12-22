using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_TwoClasses
{
    class Balls
    {
        public int size { get; set; }
        private Colors color { get; set; }
        private int throws;

        public int nThrows
        {
            get
            {
                return throws;
            }
            set
            {
                throws = value;
            }

        }

        public Balls(int size, Colors color)
        {
            this.size = size;
            this.color = color;
            this.throws = 0;
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
