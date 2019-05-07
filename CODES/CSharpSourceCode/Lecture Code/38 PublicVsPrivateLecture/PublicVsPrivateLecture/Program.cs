using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVsPrivateLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.SetColor("red");
            Car1.SetBrand("Toyota");

            Car Car2 = new Car("green", "Honda");

            Car1.Accelerate(20);
            Car2.Accelerate(20);
            Car2.Decelerate(10);

            Car1.DisplaySpeed();
            Car2.DisplaySpeed();

            Console.ReadKey();
        }
    }
}
