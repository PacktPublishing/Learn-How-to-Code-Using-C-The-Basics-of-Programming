using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(10);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop()); // outputs 3
            Console.WriteLine(stack.Pop()); // outputs 2
            Console.WriteLine(stack.Pop()); // outputs 1

            Console.ReadKey();
        }
    }
}
