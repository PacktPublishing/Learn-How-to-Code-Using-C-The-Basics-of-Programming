using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBananas = 7;
            int numApples = 5;

            Console.WriteLine("There are " + numBananas + " bananas and " + numApples + " apples"); // string concatenation

            Console.WriteLine("There are {0} bananas and {1} apples", numBananas, numApples); // string formatting

            Console.WriteLine($"There are {numBananas} bananas and {numApples} apples"); // string interpolation

            Console.WriteLine($"There are {numBananas + numApples} pieces of fruit"); // string interpolation

            Console.ReadKey();
        }
    }
}
