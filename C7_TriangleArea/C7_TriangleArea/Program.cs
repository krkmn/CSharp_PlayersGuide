using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float Area, b, h;
            b = 4f;
            h = 1.5f;
            Area = b * h / 2;
            Console.WriteLine("The area is " + Area + ".");
            Console.ReadKey();
        }
    }
}
