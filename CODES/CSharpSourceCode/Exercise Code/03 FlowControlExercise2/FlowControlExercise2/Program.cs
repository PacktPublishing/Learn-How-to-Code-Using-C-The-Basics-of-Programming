using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string likesPizza;
            bool validResponse;

            do
            {
                Console.Write("Do you like pizza? (yes/no): ");
                likesPizza = Console.ReadLine();

                if (likesPizza == "yes")
                {
                    validResponse = true;
                    Console.WriteLine("You like pizza");
                }
                else if (likesPizza == "no")
                {
                    validResponse = true;
                    Console.WriteLine("You do not like pizza");
                }
                else
                {
                    validResponse = false;
                    Console.WriteLine("You did not enter a valid response, please try again");
                    Console.WriteLine();
                }
            } while (validResponse == false);

            Console.ReadKey();
        }
    }
}
