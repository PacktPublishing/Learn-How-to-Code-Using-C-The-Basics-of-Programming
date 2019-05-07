using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> starTrekCharacters = new List<string>();

            starTrekCharacters.Add("Kirk"); // "Kirk" is added to index 0
            starTrekCharacters.Add("Spock"); // "Spock" is added to index 1
            starTrekCharacters.Add("McCoy"); // "McCoy" is added to index 2

            starTrekCharacters.Insert(2, "Scotty"); // "Scotty" is inserted into index 2 and "McCoy" is shifted up to index 3

            starTrekCharacters.RemoveAt(2); // "Scotty" is removed and "McCoy" is shifted down to index 2

            starTrekCharacters.Remove("Spock"); // "Spock" is removed and "McCoy" is shifted down to index 1

            string firstCharacter = starTrekCharacters[0]; // stores the string "Kirk" in the firstCharacter variable

            starTrekCharacters[0] = "Picard"; // "Kirk" is replaced by "Picard"

            foreach (string starTrekCharacter in starTrekCharacters)
                Console.WriteLine(starTrekCharacter);

            Console.ReadKey();
        }
    }
}
