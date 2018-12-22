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
            Console.WriteLine("color1 red is at " + color1.red);
            color1.red = 123;
            Console.WriteLine("color1 red is at " + color1.red);

            Colors color2 = new Colors(31, 41, 59, 26);
            Colors color3 = new Colors(27, 182, 81, 82);
            byte gray = color2.Grayscale();
            Console.WriteLine($"Grayscale average is {gray} and should be {(byte)(31/3+41/3+59/3)}");

            Balls ball1 = new Balls(10, color1);
            Balls ball2 = new Balls(11, color2);
            Balls ball3 = new Balls(12, color3);

            Console.WriteLine(ball1.nThrows);
            ball1.Throw();
            ball1.Throw();
            Console.WriteLine(ball1.nThrows);
            ball1.Pop();
            Console.WriteLine(ball1.size);
            ball1.Throw();
            Console.WriteLine(ball1.nThrows);
            Console.ReadKey();

        }
    }
}
