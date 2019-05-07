using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            string selection;
            int parsedInteger;
            bool error = false;

            do
            {
                Console.Write("Enter the array index of the element you wish to view: ");
                selection = Console.ReadLine();
                if (int.TryParse(selection, out parsedInteger))
                {
                    if (parsedInteger >= 0 && parsedInteger <= myArray.Length - 1)
                    {
                        error = false;
                        Console.WriteLine(myArray[parsedInteger]);
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine($"{selection} is not a valid index for the array. Please try again.");
                    }
                    
                }
                else
                {
                    error = true;
                    Console.WriteLine($"{selection} is not an integer. Please try again.");
                }
            } while (error);
            
            Console.ReadKey();
        }
    }
}
