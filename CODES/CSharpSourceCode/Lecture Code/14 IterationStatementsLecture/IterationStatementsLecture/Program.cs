using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            while ( expression ) 
            {     
	            // do this
            }
 
            */

            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
