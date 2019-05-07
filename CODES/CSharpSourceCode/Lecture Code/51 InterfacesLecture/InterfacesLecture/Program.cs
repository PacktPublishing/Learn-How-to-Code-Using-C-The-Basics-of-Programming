using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLecture
{
    interface IMyInterface
    {
        void SomeMethod();
        int AnotherMethod(string someString);
    }

    class MyClass : IMyInterface
    {
        private int x, y;

        public void MyMethod()
        {
            // method code
        }

        public void SomeMethod()
        {
            // method code
        }

        public int AnotherMethod(string myString)
        {
            // method code
            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface MyInterface;
            MyClass MyClassObject = new MyClass();
            
            MyInterface = MyClassObject;

            MyInterface.SomeMethod();
            MyInterface.AnotherMethod("hello");
        }
    }
}
