using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "a";
            string string2 = "b";

            int integer1 = 1;
            int integer2 = 2;

            Swap<string>(ref string1, ref string2);
            Swap<int>(ref integer1, ref integer2);

            Console.WriteLine(string1); // outputs b
            Console.WriteLine(string2); // outputs a
            Console.WriteLine(integer1); // outputs 2
            Console.WriteLine(integer2); // outputs 1

            Console.ReadKey();
        }

        static void Swap<T>(ref T item1, ref T item2)
        {
            T tempItem = item1;
            item1 = item2;
            item2 = tempItem;
        }
    }
}
