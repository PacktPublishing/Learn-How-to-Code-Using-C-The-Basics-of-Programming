using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLecture2
{
    class Stack
    {
        private Object[] array;
        private int currentIndex;

        public Stack(int size)
        {
            array = new Object[size];
            currentIndex = 0;
        }

        public void Push(Object item)
        {
            array[currentIndex] = item;
            currentIndex++;
        }

        public Object Pop()
        {
            currentIndex--;
            return array[currentIndex];
        }
    }
}
