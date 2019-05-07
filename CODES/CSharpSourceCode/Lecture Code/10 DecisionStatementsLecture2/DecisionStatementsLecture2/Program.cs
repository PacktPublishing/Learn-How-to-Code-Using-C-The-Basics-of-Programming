using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementsLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            int x = 10;

            if (age >= 18)
            {
                x = 5;
                Console.WriteLine("You are old enough to vote!");
                Console.WriteLine("Congratulations!");
            }

            Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
