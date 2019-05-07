using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceCar myRaceCar = new RaceCar(5);
            RaceCar myRaceCar2 = new RaceCar("red", "Toyoya", 5);

            Console.ReadKey();
        }
    }
}
