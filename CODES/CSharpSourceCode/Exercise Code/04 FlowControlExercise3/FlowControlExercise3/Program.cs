using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAttempts = 3;
            string doorChoice;

            for (int i = 1; i <= totalAttempts; i++)
            {
                Console.Write("Choose a door between 1-5 and win a prize! This is attempt #" + i + ": ");
                doorChoice = Console.ReadLine();

                switch (doorChoice)
                {
                    case "1":
                        Console.WriteLine("You win a balloon!");
                        break;
                    case "2":
                        Console.WriteLine("You win a stuffed animal!");
                        break;
                    case "3":
                        Console.WriteLine("You win a bicycle!");
                        break;
                    case "4":
                        Console.WriteLine("You win a car!");
                        break;
                    case "5":
                        Console.WriteLine("You win a million dollars!");
                        break;
                    default:
                        Console.WriteLine("That's not even a choice. You win nothing!");
                        break;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
