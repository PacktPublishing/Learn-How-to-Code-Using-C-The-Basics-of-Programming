using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            string[] groceries = new string[arraySize];
            string substring;
            int count = 0;

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter grocery item {i+1}: ");
                groceries[i] = Console.ReadLine();
            }

            Console.Write("\nEnter a substring to search for: ");
            substring = Console.ReadLine();

            foreach (string groceryItem in groceries)
            {
                if (groceryItem.Contains(substring))
                    count++;
            }

            if (count == 1)
            {
                Console.WriteLine($"\nThere is {count} element that contains the substring \"{substring}\"");
            }
            else
            {
                Console.WriteLine($"\nThere are {count} elements that contain the substring \"{substring}\"");
            }

            Console.ReadKey();
        }
    }
}
