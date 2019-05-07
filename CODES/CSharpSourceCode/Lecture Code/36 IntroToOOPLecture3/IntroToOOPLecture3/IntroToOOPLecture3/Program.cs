// using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;

namespace IntroToOOPLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car Car2 = new Car();

            ExistingCode.Car Car3 = new ExistingCode.Car();

            Lamp Lamp1 = new Lamp();

            Car1.color = "red";
            Car1.brand = "Toyota";
            Car1.currentSpeed = 0;

            Car2.color = "green";
            Car2.brand = "Honda";
            Car2.currentSpeed = 0;

            Car1.Accelerate(20);
            Car2.Accelerate(20);
            Car2.Decelerate(10);

            Car1.DisplaySpeed(); // 20 km/h
            Car2.DisplaySpeed(); // 10 km/h

            System.Console.ReadKey();
        }
    }
}
