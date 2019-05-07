using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementsLecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             switch ( variable ) 
             {    
                case value:       
                    // do this        
                    break;     
                case value:         
                    // do this        
                    break;     
                 ...     
                default:         
                    // do this      
                    break; 
              }

             */


            int doorNumber = 3;


            if (doorNumber == 1)
            {
                Console.WriteLine("You win a million dollars!");
            }
            else if (doorNumber == 2)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (doorNumber == 3)
            {
                Console.WriteLine("You win nothing!");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

            // This does the same thing as above
            switch (doorNumber)
            {
                case 1:
                    Console.WriteLine("You win a million dollars!");
                    break;
                case 2:
                    Console.WriteLine("You win a new car!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("You win nothing!");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadKey();

        }
    }
}
