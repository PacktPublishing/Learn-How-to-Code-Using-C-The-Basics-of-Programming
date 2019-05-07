using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVsPrivateLecture
{
    class Car
    {
        private string color;
        private string brand;
        private int currentSpeed;

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

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            if (isBrandValid(brand))
            {
                this.brand = brand;
            }
            else
            {
                Console.WriteLine("Invalid brand");
            }
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

        private bool isBrandValid(string brand)
        {
            List<string> brandNames = new List<string>{ "Toyota", "Honda", "Ford" };

            if (brandNames.Contains(brand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
