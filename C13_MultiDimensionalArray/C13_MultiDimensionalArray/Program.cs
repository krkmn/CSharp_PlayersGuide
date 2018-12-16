using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multidim_array = new int[4, 5];
            multidim_array[1, 1] = 1;
            int[][] matrix = new int[4][];
            matrix[0] = new int[20];
            matrix[1] = new int[20];
            matrix[2] = new int[20];
            matrix[3] = new int[20];
            Console.WriteLine(multidim_array[1, 1]);
            Console.WriteLine(multidim_array.Length); //Gives total elements in multidim array
            Console.WriteLine(multidim_array.GetLength(0)); //Gives row length in multidim array
            Console.WriteLine(multidim_array.GetLength(1)); //Gives column length in multidim array
            Console.WriteLine(matrix.Length); //Gives row length in array of arrays

            int i = 0;
            foreach (int item in multidim_array) //Writing out every element in multidim_array
            {
                Console.WriteLine($"Item {i} is {item}");
                ++i;
            }
        }
    }
}
