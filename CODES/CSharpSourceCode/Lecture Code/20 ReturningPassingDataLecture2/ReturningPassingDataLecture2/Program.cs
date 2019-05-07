using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningPassingDataLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            result = NumberSquared(4);
            Console.WriteLine(result); // outputs 16

            Console.ReadKey();
        }

        static int NumberSquared(int x)
        {
            return x * x;
        }
    }
}
