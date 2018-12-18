using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum MonthsOfTheYear { January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12 };

namespace C14_MonthsOfTheYear
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            Console.WriteLine("Give me a number: ");
            int month_int = Convert.ToInt32(Console.ReadLine());
            MonthsOfTheYear month_enum = (MonthsOfTheYear) month_int;
            if (month_int >= 1 && month_int<13)
                Console.WriteLine(month_enum);
            else
                Console.WriteLine("The number does not fall in the range of 1 to 12");
            Console.ReadKey();
        }
    }
}
