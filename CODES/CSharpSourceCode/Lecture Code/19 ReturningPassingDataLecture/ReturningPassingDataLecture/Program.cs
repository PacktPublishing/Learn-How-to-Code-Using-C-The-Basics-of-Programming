using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningPassingDataLecture
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You’re learning how to program!");
            Console.WriteLine(ReturnCongratsMessage());

            Console.WriteLine("You’re doing so well!");
            Console.WriteLine(ReturnCongratsMessage());

            Console.WriteLine("You’re going to be rich!");
            Console.WriteLine(ReturnCongratsMessage());

            Console.ReadKey();

        }

        static string ReturnCongratsMessage()
        {
            return "Congratulations!";
        }
    }
}
