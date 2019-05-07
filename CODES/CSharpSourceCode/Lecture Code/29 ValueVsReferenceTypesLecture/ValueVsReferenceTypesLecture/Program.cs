using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypesLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 1, 2, 3 };
            int[] myArray2;

            myArray2 = myArray1;

            Console.WriteLine(myArray2[0]); // outputs 1
            Console.WriteLine(myArray2[1]); // outputs 2
            Console.WriteLine(myArray2[2]); // outputs 3

            myArray2[0] = 7;
            Console.WriteLine(myArray1[0]); // outputs 7

            myArray1[0] = 1;

            myArray2 = (int[])myArray1.Clone();
            myArray2[0] = 7;
            Console.WriteLine(myArray1[0]); // outputs 1

            Console.ReadKey();
        }
    }
}
