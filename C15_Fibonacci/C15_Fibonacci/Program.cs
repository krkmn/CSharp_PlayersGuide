using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_Fibonacci
{
    class Program
    {

        /// <summary>
        /// Recursive function to find the Nth number in the Fibonacci Sequence
        /// </summary>
        /// <param name="N"></param>
        /// <returns>Returns the Nth number of the Fibonacci Sequence</returns>
        static int Fibonacci(int N)
        {
            if (N < 3)
                return 1;
            else
                //Console.WriteLine(N);
                return Fibonacci(N-1) + Fibonacci(N-2);
        }

        static void Main(string[] args)
        {
            int fib = 0;
            int fib_old = 1;
            int dummy;
            for (int i = 1; i < 11; i++)
            {
                dummy = fib;
                fib = fib + fib_old;
                fib_old = dummy;
                Console.Write(fib + " ");
            }

            Console.WriteLine();
            for(int N = 1; N < 11; N++)
                Console.WriteLine($"Number {N} of the Fibonacci Sequence is: {Fibonacci(N)}");
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
