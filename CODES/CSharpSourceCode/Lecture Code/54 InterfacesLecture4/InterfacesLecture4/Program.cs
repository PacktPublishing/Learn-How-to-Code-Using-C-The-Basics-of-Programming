using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book("War and Peace", "Leo Tolstoy", 1392);
            Film Film1 = new Film("Pulp Fiction", "Quentin Tarantino", 1994, 178);

            PrintObject(Book1);
            PrintObject(Film1);

            Console.ReadKey();
        }

        static void PrintObject(IDisplay displayObject)
        {
            Console.WriteLine("Here is the object's data:\n");
            Console.WriteLine("##############################################################");
            Console.WriteLine("**************************************************************\n");

            displayObject.DisplayInfo(); // displayObject can only hold objects that implement the IDisplay interface, so we know whatever object it holds has a DisplayInfo() method

            Console.WriteLine("\n**************************************************************");
            Console.WriteLine("##############################################################\n\n");
        }
    }
}
