using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int layers;
            Console.WriteLine("How many layers do you want? ");
            string layer_string = Console.ReadLine();
            layers = Convert.ToInt32(layer_string);

            for (int L = 1; L <= layers; L++)
            {
                for (int space = 0; space < (layers - L); space++)
                {
                Console.Write(" ");
                }
                for (int star = 0; star < ((L - 1) * 2 + 1); star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
