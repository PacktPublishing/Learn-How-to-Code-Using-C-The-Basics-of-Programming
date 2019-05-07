using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string guacamoleResponse;
            bool isGuacamoleOnSale;
            double moneyInPocket;

            Console.Write("Is guacamole on sale? (yes/no): ");
            guacamoleResponse = Console.ReadLine();

            if (guacamoleResponse == "yes")
                isGuacamoleOnSale = true;
            else
                isGuacamoleOnSale = false;

            Console.Write("How much money is in your pocket? ");
            moneyInPocket = Convert.ToDouble(Console.ReadLine());

            if ((isGuacamoleOnSale && moneyInPocket >= 10) || moneyInPocket >= 100)
                Console.WriteLine("Let's go shopping!");
            else
                Console.WriteLine("Let's stay home");

            Console.ReadKey();
        }
    }
}
