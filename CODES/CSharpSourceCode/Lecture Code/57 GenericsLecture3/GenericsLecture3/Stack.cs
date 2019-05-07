using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLecture3
{
    class Stack<T>
    {
        private T[] array;
        private int currentIndex;

        public Stack(int size)
        {
            array = new T[size];
            currentIndex = 0;
        }

        public void Push(T item)
        {
            array[currentIndex] = item;
            currentIndex++;
        }

        public T Pop()
        {
            currentIndex--;
            return array[currentIndex];
        }
    }
}
