using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void PrintObject(IDisplay displayObject)
        {
            Console.WriteLine("Here is the object's data:\n");
            Console.WriteLine("##############################################################");
            Console.WriteLine("**************************************************************\n");

            displayObject.DisplayInfo(); // displayObject can only hold objects that implement the IDisplay interface, so we know whatever object it holds has a DisplayInfo() method

            Console.WriteLine("\n**************************************************************");
            Console.WriteLine("##############################################################");
        }
    }
}
