using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector MyVector = new Vector(1,2,3);
            Vector MyVector2;

            MyVector.X = 3;
            MyVector.Y = 2;
            MyVector.Z = 1;

            MyVector.DisplayVector();

            MyVector2 = MyVector; // makes a copy of each field

            Console.ReadKey();
        }
    }
}
