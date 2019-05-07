using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsLecture4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 3; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
