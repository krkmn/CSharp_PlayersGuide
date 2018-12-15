using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_NegativeOrPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("We are going to multiply two numbers, this program will then determine if the product is negative or positive." +
                "input value_1 and value_2, separate with return key, end with return key");
            string a_as_string = Console.ReadLine();
            string b_as_string = Console.ReadLine();

            a = Convert.ToSingle(a_as_string);
            b = Convert.ToSingle(b_as_string);

            bool pos_or_neg = false;
            if (a>=0)
            {
                if (b >= 0)
                    pos_or_neg = true;
            }
            else
            {
                if (b < 0)
                    pos_or_neg = true;
            }

            if(pos_or_neg)
                Console.WriteLine("Value is positive");
            else
                Console.WriteLine("Value is negative");

            Console.ReadKey();
        }
    }
}
