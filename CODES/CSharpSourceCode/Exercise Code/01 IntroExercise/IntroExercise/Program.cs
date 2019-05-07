using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersName;
            int usersAge;
            string friendsName;
            int friendsAge;

            Console.Write("Enter your name: ");
            usersName = Console.ReadLine();
            Console.Write("Enter your age: ");
            usersAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + usersName + " and you are " + usersAge + " years old");
            Console.WriteLine();

            Console.Write("Enter your friend's name: ");
            friendsName = Console.ReadLine();
            Console.Write("Enter your friend's age: ");
            friendsAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your friend's name is " + friendsName + " and they are " + friendsAge + " years old");
            Console.WriteLine();

            Console.WriteLine("There are " + (usersAge + friendsAge) + " years between the two of you");

            Console.ReadKey();
        }
    }
}
