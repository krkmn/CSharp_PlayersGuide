using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Casting
{
    class Program
    {
        static void Main(string[] args)       
        {
            double a = 1.0 + 1 + 1.0f;
            Console.WriteLine($"a is {a}");

            int x = (int)(7 + 3.0 / 4.0 * 2); //Should be 8
            Console.WriteLine($"x is {x}");

            Console.WriteLine((1 + 1) / 2 * 3); //Should be 3

            Console.WriteLine($"Infinity {double.PositiveInfinity}");

            short sha = 30000;
            short shb = sha;
            short sum = (short)(sha + shb); //byte and short types are always converted to int while doing math --> have to convert them back here
            Console.WriteLine($"Let us try overflow a + b: {sum}.");
        }
    }
}
