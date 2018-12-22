using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_TwoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Colors color1 = new Colors(34, 55, 89, 144);
            Colors color2 = new Colors(31, 41, 59, 26);
            Colors color3 = new Colors(27, 182, 81, 82);
            int gray = color1.Grayscale();
            Console.WriteLine($"Grayscale average is {gray}");

            Balls ball1 = new Balls(10, color1);
            Balls ball2 = new Balls(11, color2);
            Balls ball3 = new Balls(12, color3);

            Console.WriteLine(ball1.throws);
            ball1.Throw();
            ball1.Throw();
            Console.WriteLine(ball1.throws);
            ball1.Pop();
            Console.WriteLine(ball1.size);
            ball1.Throw();
            Console.WriteLine(ball1.throws);


        }
    }
}
