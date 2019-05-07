using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingLecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;

            Console.Write("Enter an integer between 1-100: ");

            try
            {
                selection = Convert.ToInt32(Console.ReadLine());

                if (selection < 1 || selection > 100)
                    throw new Exception($"Invalid input. {selection} is not between 1-100.");

                Console.WriteLine();
                Console.WriteLine($"You entered {selection}");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
