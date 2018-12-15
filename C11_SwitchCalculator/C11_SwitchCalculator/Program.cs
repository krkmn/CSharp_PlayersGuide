using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11_SwitchCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("Input two numbers to perform a math operation on, separate with return");
            string a_as_str = Console.ReadLine();
            string b_as_str = Console.ReadLine();
            a = Convert.ToSingle(a_as_str);
            b = Convert.ToSingle(b_as_str);

            Console.WriteLine("Input math operation: ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Answer is {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Answer is {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Answer is {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"Answer is {a / b}");
                    break;
                case "%":
                    Console.WriteLine($"Answer is {a % b}");
                    break;
                case "^":
                    Console.WriteLine($"Answer is {Math.Pow(a, b)}");
                    break;
            }

            Console.ReadKey();
        }
    }
}
