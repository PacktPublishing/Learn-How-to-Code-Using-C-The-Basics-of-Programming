using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Car.GetNumCarObjects()); // outputs 0

            Car Car1 = new Car("red", "Toyota");
            Console.WriteLine(Car.GetNumCarObjects()); // outputs 1

            Car Car2 = new Car("green", "Honda");
            Console.WriteLine(Car.GetNumCarObjects()); // outputs 2

            Console.ReadKey();
        }
    }
}
