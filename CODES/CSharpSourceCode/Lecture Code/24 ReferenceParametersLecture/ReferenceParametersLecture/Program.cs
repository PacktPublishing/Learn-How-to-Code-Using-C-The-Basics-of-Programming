using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParametersLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            ChangeNumber(x);

            Console.WriteLine(x); // outputs 5

            Console.ReadKey();
        }

        static void ChangeNumber(int y)
        {
            y = 0;
        }
    }
}
