using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            int selection;

            Console.Write("Enter the array index of the element you wish to view: ");
            selection = Int32.Parse(Console.ReadLine());
            Console.WriteLine(myArray[selection]);

            Console.ReadKey();
        }
    }
}
