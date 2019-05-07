using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPLecture
{
    class Lamp
    {
        public string color;
        public bool isOn;
        
        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lamp Lamp1 = new Lamp();
            Lamp Lamp2 = new Lamp();
            Lamp Lamp3 = new Lamp();

            Lamp1.color = "green";
            Lamp1.isOn = true;

            Lamp2.color = "blue";
            Lamp2.isOn = false;

            Lamp3.color = "red";
            Lamp3.isOn = true;

            Console.WriteLine(Lamp1.isOn); // outputs True

            Lamp1.TurnOff();

            Console.WriteLine(Lamp1.isOn); // outputs False

            Console.ReadKey();
        }
    }
}
