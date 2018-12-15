using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("Insert your score: ");
            string score_as_text = Console.ReadLine();
            score = Convert.ToInt32(score_as_text);

            if (score == 100)
            {
                Console.WriteLine("You got an A and a perfect score!");

            }
            else if (score >= 90)
                Console.WriteLine("You got an A!");
            else if (score >= 80)
                Console.WriteLine("You got a B!");
            else if (score >= 70)
                Console.WriteLine("You got a C ...");
            else if (score >= 60)
                Console.WriteLine("You got a D .... ....");
            else
                Console.WriteLine("You failed!");
            Console.ReadKey();
        }
    }
}
