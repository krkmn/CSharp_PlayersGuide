using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_MinimumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 22, 13, 45123, 123, 3123, 31, 4, 123, 6 };
            int current_minimum = Int32.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < current_minimum)
                    current_minimum = array[i];

            }
            Console.WriteLine($"Minimum value in the array is {current_minimum}");
            Console.ReadKey();
        }
    }
}
