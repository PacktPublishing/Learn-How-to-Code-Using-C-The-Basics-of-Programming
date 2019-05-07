using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void PrintObject(Object obj)
        {
            Console.WriteLine("Here is the object's data:\n");
            Console.WriteLine("##############################################################");
            Console.WriteLine("**************************************************************\n");

            obj.DisplayInfo(); // compiler error - how do you call a method when you don't know what object will be passed in?

            Console.WriteLine("\n**************************************************************");
            Console.WriteLine("##############################################################");
        }
    }
}
