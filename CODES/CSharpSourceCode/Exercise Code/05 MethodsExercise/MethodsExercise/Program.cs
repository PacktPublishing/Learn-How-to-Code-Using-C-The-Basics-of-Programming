using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            SayHello(Console.ReadLine());

            Console.Write("Enter another name: ");
            SayHello(Console.ReadLine());

            Console.Write("Enter a third name: ");
            SayHello(Console.ReadLine(), true);

            Console.ReadKey();
        }

        static void SayHello(string name, bool askHowAreYou = false)
        {
            Console.Write("Hello " + name + "! ");
            if (askHowAreYou)
                Console.WriteLine("How are you?");
            else
                Console.WriteLine();
            Console.WriteLine();
        }
    }
}
