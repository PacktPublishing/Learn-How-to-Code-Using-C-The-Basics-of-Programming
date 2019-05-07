using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture
{
    class RaceCar : Car
    {
        private int numNitros = 5;

        public void UseNitro()
        {
            if (numNitros > 0)
            {
                Accelerate(20);
            }
            else
            {
                Console.WriteLine("Out of nitro!");
            }
        }
    }
}
