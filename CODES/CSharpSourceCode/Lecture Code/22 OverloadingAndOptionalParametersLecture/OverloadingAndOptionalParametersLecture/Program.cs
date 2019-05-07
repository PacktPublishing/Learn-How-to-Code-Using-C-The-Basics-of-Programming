using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAndOptionalParametersLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultInteger;
            double resultDouble;

            resultInteger = NumbersAdded(3, 5);    // calls NumbersAdded(int x, int y)
            resultDouble = NumbersAdded(4.3, 7.9); // calls NumbersAdded(double x, double y)
            resultInteger = NumbersAdded(7, 2, 4); // calls NumbersAdded(int x, int y, int z)

            Console.WriteLine(resultInteger); // calls Console.WriteLine(int value)
            Console.WriteLine(resultDouble);  // calls Console.WriteLine(double value)

            Console.ReadKey();
        }

        static int NumbersAdded(int x, int y)
        {
            return x + y;
        }

        static double NumbersAdded(double x, double y)
        {
            return x + y;
        }

        static int NumbersAdded(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
