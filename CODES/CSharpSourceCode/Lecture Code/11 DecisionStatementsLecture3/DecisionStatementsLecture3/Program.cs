using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementsLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote!");
                Console.WriteLine("Sorry!");
            }

            Console.ReadKey();

        }
    }
}
