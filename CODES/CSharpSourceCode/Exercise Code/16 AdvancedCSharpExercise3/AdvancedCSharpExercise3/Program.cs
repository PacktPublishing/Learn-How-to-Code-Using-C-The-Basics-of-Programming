using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            SnazzyQueue<int> q = new SnazzyQueue<int>();
            int selection;

            do
            {
                Console.WriteLine("1 - Enqueue");
                Console.WriteLine("2 - Dequeue");
                Console.WriteLine("3 - Exit");
                selection = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (selection == 1)
                {
                    Console.Write("Enter an item to enqueue: ");
                    q.Enqueue(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine();
                }
                else if (selection == 2)
                {
                    Console.WriteLine($"{q.Dequeue().ToString()} has been removed from the queue");
                    Console.WriteLine();
                }

            } while (selection != 3);
        }
    }
}
