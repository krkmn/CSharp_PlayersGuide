using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_AverageOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 1};

            int total = 0;

            for (int i = 0; i < array.Length; i++)
                total += array[i];

            float average = (float)total / array.Length;

            Console.WriteLine("Average is " + average);
            Console.ReadKey();
        }
    }
}
