using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementsLecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;

            if (age >= 21)
            {
                Console.WriteLine("You are old enough to purchase alcohol.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You aren't old enough to do anything.");
            }

            Console.ReadKey();

        }
    }
}
