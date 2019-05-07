using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise3
{
    class SnazzyQueue<T>
    {
        List<T> data;

        public SnazzyQueue()
        {
            data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            Console.WriteLine($"{item.ToString()} has been added to the queue");
        }

        public T Dequeue()
        {
            T item = data[0];
            data.RemoveAt(0);
            return item;
        }
    }
}
