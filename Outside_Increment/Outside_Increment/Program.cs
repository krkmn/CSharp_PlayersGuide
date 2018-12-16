/* Incrementing as a prefix or postfix, just to untie my brain around this concept */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outside_Increment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            while (i<10)
            {
                Console.Write($"i iteration {i}:");
                Console.Write(i++ + ":"); //Postfix incrementing i
                Console.Write(i);
                Console.Write($"|j iteration {j}:");
                Console.Write(++j + ":"); //Prefix incrementing j
                Console.WriteLine(j);
                Console.ReadKey();
            }


        }
    }
}
