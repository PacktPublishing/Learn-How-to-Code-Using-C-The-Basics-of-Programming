using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 765;
            double myDouble = 7.2;

            myDouble = myInteger; // implicit conversion
            myInteger = (int)myDouble; // explicit conversion

            //----------------------------------------------------------

            string myString = "5";
            myInteger = Convert.ToInt32(myString);
        }
    }
}
