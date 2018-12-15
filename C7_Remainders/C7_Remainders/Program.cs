using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, quotient, remainder;
            a = 410;
            b = 69;
            quotient = a / b;
            remainder = a % b;
            int value = quotient * b + remainder;
            Console.WriteLine("a: " + a + " b: " + b + " quotient: " + quotient + " remainder: " + remainder + " value: " +
                value);
            Console.ReadKey();
        }
    }
}
