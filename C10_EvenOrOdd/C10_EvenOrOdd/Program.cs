using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder;
            bool even;
            Console.WriteLine("Give me a number: ");
            string number_as_string = Console.ReadLine();

            remainder = Convert.ToInt32(number_as_string) % 2;

            even = (remainder == 0);

            if (even)
                Console.WriteLine("Even number!");
            else
                Console.WriteLine("Odd number");

            Console.ReadKey();

        }
    }
}
