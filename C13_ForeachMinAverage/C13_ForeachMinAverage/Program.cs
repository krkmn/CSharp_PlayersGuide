using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_ForeachMinAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 45, 4, 124, 4, 22, 35, 3 };
            int current_minimum = Int32.MaxValue;
            int total = 0;

            foreach (int item in array)
            {
                if (current_minimum > item)
                    current_minimum = item;

                total += item;
            }

            float average = (float)total / array.Length;

            Console.WriteLine($"The minimum value of the array is {current_minimum} and the average is {average}");
            Console.ReadKey();
        }
    }
}
