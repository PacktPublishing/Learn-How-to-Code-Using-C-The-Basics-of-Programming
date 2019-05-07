using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    static class Inventory
    {
        static private List<Product> products;

        static Inventory()
        {
            products = new List<Product>();
        }

        static public void AddProduct(Product p)
        {
            products.Add(p);
        }

        static public void DisplayInventory()
        {
            double totalInventoryValue = 0;
            Console.WriteLine("Current inventory: ");
            Console.WriteLine("*********************************************\n");
            foreach (Product p in products)
            {
                p.DisplayInfo();
                Console.WriteLine();
                totalInventoryValue += p.GetTotalValue();
            }
            Console.WriteLine($"Total inventory value: ${totalInventoryValue.ToString("F")}");
        }
    }
}
