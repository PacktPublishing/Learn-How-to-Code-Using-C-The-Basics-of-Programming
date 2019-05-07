using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            byte selection = 0;

            do
            {
                Console.WriteLine("Choose an option from the menu");
                Console.WriteLine("1 - Enter Product");
                Console.WriteLine("2 - Display Inventory");
                Console.WriteLine("3 - Exit");

                selection = Convert.ToByte(Console.ReadLine());

                Console.WriteLine();

                if (selection == 1)      
                {
                    Product p = new Product();
                    p.InputInfo();
                    Inventory.AddProduct(p);

                } else if (selection == 2)
                {
                    Inventory.DisplayInventory();
                }

                Console.WriteLine();

            } while (selection != 3);
        }
    }
}
