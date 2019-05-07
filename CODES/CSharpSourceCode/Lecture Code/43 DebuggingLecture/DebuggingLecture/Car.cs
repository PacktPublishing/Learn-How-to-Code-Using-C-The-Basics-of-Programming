using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingLecture
{
    class Car
    {
        public string color;
        public string brand;
        public int currentSpeed;

        public Car()
        {
            currentSpeed = 0;
        }

        public Car(string color, string brand)
        {
            this.color = color;
            this.brand = brand;
            currentSpeed = 0;
        }

        public void Accelerate(int speedIncrease)
        {
            currentSpeed += speedIncrease;
        }

        public void Decelerate(int speedDecrease)
        {
            currentSpeed -= speedDecrease;
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h");
        }
    }
}
