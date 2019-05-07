using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    class Product
    {
        private string name;
        private double price;
        private int quantity;

        public void InputInfo()
        {
            Console.Write("Enter product name: ");
            name = Console.ReadLine();
            Console.Write("Enter price: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nProduct added to inventory");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Price: ${price.ToString("F")}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Value: ${GetTotalValue().ToString("F")}");
        }

        public double GetTotalValue()
        {
            return price * quantity;
        }
    }
}
