using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(10);
            string myString;
            int myInteger;

            stack.Push("hello");
            stack.Push("world");

            myString = stack.Pop();
            myInteger = stack.Pop(); // produces a compiler error, which is what we want

            stack.Push("hello");
            stack.Push(4); // produces a compiler error, which is what we want
            stack.Push(2.34); // produces a compiler error, which is what we want

            // can create Stacks of ANY type!
            Stack<int> stack2 = new Stack<int>(10);
            Stack<double> stack3 = new Stack<double>(10);
        }
    }
}
