using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("red", "Toyota");
            RaceCar myRaceCar = new RaceCar("green", "Honda", 5);
            PickupTruck myPickupTruck = new PickupTruck("white", "Ford", 100);

            myCar.DisplayInfo();
            myRaceCar.DisplayInfo();
            myPickupTruck.DisplayInfo();

            Console.ReadKey();
        }
    }
}
