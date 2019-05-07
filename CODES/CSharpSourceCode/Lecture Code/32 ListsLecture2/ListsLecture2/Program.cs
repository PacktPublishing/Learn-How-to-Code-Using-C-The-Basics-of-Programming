using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doesContain;
            int index;
            List<string> starTrekCharacters = new List<string>();

            starTrekCharacters.Add("Kirk");
            starTrekCharacters.Add("Spock");
            starTrekCharacters.Add("Picard");
            starTrekCharacters.Add("McCoy");

            Console.WriteLine(starTrekCharacters.Count); // outputs 4

            doesContain = starTrekCharacters.Contains("Kirk"); // returns true
            doesContain = starTrekCharacters.Contains("Scotty"); // returns false

            index = starTrekCharacters.IndexOf("Kirk"); // returns 0
            index = starTrekCharacters.IndexOf("Scotty"); // returns -1

            foreach (string starTrekCharacter in starTrekCharacters)
                Console.WriteLine(starTrekCharacter);
            Console.WriteLine();

            starTrekCharacters.Sort(); // sorts in alphabetical order for text data and numerical order for numeric data

            foreach (string starTrekCharacter in starTrekCharacters)
                Console.WriteLine(starTrekCharacter);
            Console.WriteLine();

            starTrekCharacters.Reverse(); // reverses the order of elements in the list

            foreach (string starTrekCharacter in starTrekCharacters)
                Console.WriteLine(starTrekCharacter);

            starTrekCharacters.Clear(); // removes all elements; list is now empty

            Console.ReadKey();
        }
    }
}
