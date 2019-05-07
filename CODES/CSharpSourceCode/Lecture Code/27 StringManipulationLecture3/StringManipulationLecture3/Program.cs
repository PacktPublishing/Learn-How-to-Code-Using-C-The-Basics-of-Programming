using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;

            myString = "abc";
            Console.WriteLine(myString.Length); // outputs "3"

            myString = "I'm Learning C#";
            Console.WriteLine(myString.ToLower()); // outputs "i'm learning c#"
            Console.WriteLine(myString.ToUpper()); // outputs "I'M LEARNING C#"

            myString = "This is fun!";
            Console.WriteLine(myString.Contains("fun")); // outputs "True"
            Console.WriteLine(myString.Contains("boring")); // outputs "False"

            myString = "This is fun!";
            Console.WriteLine(myString.IndexOf('i')); // outputs "2"
            Console.WriteLine(myString.IndexOf('j')); // outputs "-1"

            myString = "This is fun!";
            Console.WriteLine(myString.Substring(5)); // outputs "is fun!"
            Console.WriteLine(myString.Substring(5, 2)); // outputs "is"

            myString = "This is fun!";
            Console.WriteLine(myString.Remove(5)); // outputs "This "
            Console.WriteLine(myString.Remove(5, 2)); // outputs "This fun!"

            myString = "This is fun!";
            Console.WriteLine(myString.Replace("fun","awesome")); // outputs "This is awesome!"

            int myInt = 5;
            double myDouble = 5.44735453;
            bool myBool = false;

            myString = myInt.ToString();
            myString = myDouble.ToString("F"); // "5.45" will be stored in myString
            myString = myBool.ToString();

            Console.ReadKey();
        }
    }
}
