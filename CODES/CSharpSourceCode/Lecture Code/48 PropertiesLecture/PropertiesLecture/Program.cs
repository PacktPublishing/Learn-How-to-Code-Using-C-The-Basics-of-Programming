using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLecture
{
    class MyClass
    {
        private int _myInteger;

        public int MyInteger
        {
            get
            {
                return _myInteger;
            }
            set
            {
                _myInteger = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject = new MyClass();

            MyObject.MyInteger = 5; // calls set accessor

            Console.WriteLine(MyObject.MyInteger); // calls get accessor

            Console.ReadKey();
        }
    }
}
