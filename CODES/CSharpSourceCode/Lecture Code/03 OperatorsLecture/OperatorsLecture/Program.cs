using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // +  -  *  /

            int x = 1;
            int y = 1;
            int sum;

            sum = x + y; // evaluates to 2


            //------------------------------------------------------------------


            double double1 = 5.0 / 2.0; // evaluates to 2.5
            double double2 = 5 / 2; // evaluates to 2


            //------------------------------------------------------------------


            int remainder;
            remainder = 7 % 3; // evaluates to 1
            remainder = 6 % 3; // evaluates to 0


            //------------------------------------------------------------------


            y = 1;
            x = ++y; // y is incremented to 2, x is set to 2

            y = 2;
            x = --y; // y is decremented to 1, x is set to 1

            y = 1;
            x = y++; // x is set to 1, y is incremented to 2

            y = 2;
            x = y--; // x is set to 2, y is decremented to 1


            //------------------------------------------------------------------


            // these two statements do the same thing
            x += y;
            x = x + y;

            // these two statements do the same thing
            x -= y;
            x = x - y;

            // these two statements do the same thing
            x *= y;
            x = x * y;

            // these two statements do the same thing
            x /= y;
            x = x / y;


            //------------------------------------------------------------------


            sum = 1 + 2 * 5; // evaluates to 11

            // HIGHEST PRECEDENCE
            // ++, -- (prefix)
            // *, /, %
            // +, -
            // =, +=, -=, *=, /=
            // ++, -- (postfix)
            // LOWEST PRECEDENCE

            sum = (1 + 2) * 5; // evaluates to 15


            //------------------------------------------------------------------


            string string1 = "pro";
            string string2 = "gramming";
            Console.WriteLine(string1 + string2); // outputs "programming"


            //------------------------------------------------------------------

            Console.ReadKey();
        }
    }
}
