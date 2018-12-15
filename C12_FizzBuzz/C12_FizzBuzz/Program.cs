using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = 1;
            while(start<=100)
            {

                if (start % 3 == 0 && start % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (start % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (start % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(start);
                start++;
            }

            Console.ReadKey();
        }
    }
}
