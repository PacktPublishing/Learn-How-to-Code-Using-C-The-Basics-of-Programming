using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture3
{
    class PickupTruck : Car
    {
        private int bedLength;

        public PickupTruck(int bedLength) : base()
        {
            this.bedLength = bedLength;
        }

        public PickupTruck(string color, string brand, int bedLength) : base(color, brand)
        {
            this.bedLength = bedLength;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h and has a bed length of {bedLength} inches");
        }
    }
}
