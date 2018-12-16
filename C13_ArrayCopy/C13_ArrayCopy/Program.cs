using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array_original = new string[] { "Hello", ",", "my", "name", "is", "W"};
            string[] array_copy = new string[array_original.Length];

            for (int i = 0; i < array_original.Length; i++)
            {
                array_copy[i] = array_original[i];
            }

            for (int i = 0; i < array_original.Length; i++)
            {
                Console.Write(array_original[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < array_copy.Length; i++)
            {
                Console.Write(array_copy[i]+ " " );
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
