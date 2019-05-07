using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesVsReferenceTypesLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 1, 2, 3 };

            someMethod(myArray1);
            Console.WriteLine(myArray1[0]); // outputs 7

            myArray1[0] = 1;

            someMethod2(myArray1);
            Console.WriteLine(myArray1[0]); // outputs 1

            someMethod3(ref myArray1);
            Console.WriteLine(myArray1[0]); // outputs 0

            Console.ReadKey();
        }

        static void someMethod(int[] myArray2)
        {
            myArray2[0] = 7;
        }

        static void someMethod2(int[] myArray2)
        {
            myArray2 = new int[3];
        }

        static void someMethod3(ref int[] myArray2)
        {
            myArray2 = new int[3];
        }
    }
}
