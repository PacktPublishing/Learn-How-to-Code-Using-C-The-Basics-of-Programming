using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAndOptionalParametersLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RaiseToPower(2));    // 2^2 = 4
            Console.WriteLine(RaiseToPower(2, 3)); // 2^3 = 8

            Console.ReadKey();
        }

        static int RaiseToPower(int baseNumber, int power = 2)
        {
            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}
