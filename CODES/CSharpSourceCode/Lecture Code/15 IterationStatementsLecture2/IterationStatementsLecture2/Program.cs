using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            do
            {     
	            // do this
            }
            while ( expression ); 
 
            */

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 3);

            Console.ReadKey();

        }
    }
}
