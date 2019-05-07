using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumberArray = { 2, 5, 7 };
            int[] myNumberArray2 = new int[3];

            Console.WriteLine(myNumberArray[0]); // outputs 2

            myNumberArray[1] = 12; // replaces the 5 stored in index 1

            for (int index = 0; index < myNumberArray.Length; index++)
                Console.WriteLine(myNumberArray[index]);

            foreach (int number in myNumberArray)
                Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
