using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 5;
            
            Car Car1 = new Car("red", "Toyota");

            myInteger = 7;

            Car1.Accelerate(20);
            Car1.Decelerate(10);

            Console.WriteLine(myInteger);

            Car1.Accelerate(20);
            Car1.Decelerate(10);

            if (myInteger > 5)
            {
                Console.WriteLine(myInteger);
            }

            Console.ReadKey();
        }
    }
}
