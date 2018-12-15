using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            string height, base_;
            float area, volume;
            float pi = 3.141592653589793f;
            float radius;

            Console.WriteLine("Input height and base, separated by the return key and end with the return key: ");
            height = Console.ReadLine();
            base_ = Console.ReadLine();

            radius = Convert.ToSingle(base_) / 2;
            volume = Convert.ToSingle(height)*  radius * radius * pi;
            area = 2 * pi * radius * (Convert.ToSingle(height) + radius);

            Console.WriteLine($"Volume is {volume} surface area is {area}.");
            Console.ReadKey();

        }
    }
}
