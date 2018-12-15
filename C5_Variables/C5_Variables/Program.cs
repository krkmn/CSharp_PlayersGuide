using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            score = 3;
            int the_meaning_of_life = 42;
            Console.WriteLine(the_meaning_of_life);
            Console.ReadKey();
            int a, b;
            a = 10;
            b = 2;

            b = a;
            a = -3;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
