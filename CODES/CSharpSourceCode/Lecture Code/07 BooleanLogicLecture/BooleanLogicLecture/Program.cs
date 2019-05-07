using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = false;
            Console.WriteLine(answer); // outputs “False” to the screen

            //BOOLEAN OPERATORS
            //  ==  equality
            //  !=  inequality
            //  !   NOT
            //  >   Greater than
            //  <   Less than
            //  >=  Greater than or equal to
            //  <=  Less than or equal to
            //  &&  logical AND
            //  ||  logical OR


            answer = (1 == 1); // evaluates to true
            answer = (1 != 2); // evaluates to true
            answer = !(false); // evaluates to true

            answer = (2 > 1);  // evaluates to true
            answer = (1 < 2);  // evaluates to true
            answer = (2 >= 1); // evaluates to true
            answer = (2 >= 2); // evaluates to true
            answer = (1 <= 2); // evaluates to true
            answer = (2 <= 2); // evaluates to true

            answer = (true && true);   // evaluates to true
            answer = (true && false);  // evaluates to false
            answer = (false && false); // evaluates to false

            answer = (true || true);   // evaluates to true
            answer = (true || false);  // evaluates to true
            answer = (false || false); // evaluates to false

            Console.ReadKey();

        }
    }
}
