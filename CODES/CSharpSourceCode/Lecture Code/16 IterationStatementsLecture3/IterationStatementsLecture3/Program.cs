using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            for (initialize variable; expression; update variable)
            {
                // do this
            }

            */

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
