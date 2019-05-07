using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroMethodsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              
            returnType Name( parameters )
            {
                // do this
            }

            */

            Console.WriteLine("You’re learning how to program!");
            PrintCongrats();

            Console.WriteLine("You’re doing so well!");
            PrintCongrats();

            Console.WriteLine("You’re going to be rich!");
            PrintCongrats();

            Console.ReadKey();

        }

        static void PrintCongrats()
        {
            Console.WriteLine("Congratulations!!!!!!!");
        }

    }

}
