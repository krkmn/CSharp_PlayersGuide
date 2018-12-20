using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_ReverseArray
{
    class Program
    {
       static int[] GenerateNumbers(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = i;
            return array;
        }

        static void Reverse(int[] args)
        {
            int dummy = 0;
            for (int i = 0; i < args.Length / 2; ++i)
            {
                dummy = args[i];
                args[i] = args[args.Length - i - 1];
                args[args.Length - i - 1] = dummy;
            }
        }

        static void PrintNumbers(int[] args)
        {
            foreach (int num in args)
                Console.Write($"{num} ");
        }

        static void Main(string[] args)
        {
           int[] array = GenerateNumbers(12);
           Reverse(array);
           PrintNumbers(array);
        }
    }
}
