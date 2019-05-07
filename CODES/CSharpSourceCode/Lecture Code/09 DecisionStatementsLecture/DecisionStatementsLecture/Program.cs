using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             if ( expression )
                // do this

            */

            int age = 16;

            if (age >= 18)
                Console.WriteLine("You are old enough to vote!");

            Console.WriteLine("Have a nice day!");

            Console.ReadKey();

        }
    }
}
