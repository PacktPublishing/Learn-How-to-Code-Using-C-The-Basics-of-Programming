using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput;

            Console.Write("Enter a character: ");
            userInput = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine("You entered: " + userInput);

            Console.ReadKey();

        }
    }
}
