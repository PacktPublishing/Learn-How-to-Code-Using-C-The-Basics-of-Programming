using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationsLecture
{
    class Program
    {
        enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main(string[] args)
        {
            DayOfWeek currentDay;

            currentDay = DayOfWeek.Teusday; // compiler error

            currentDay = DayOfWeek.Tuesday;

            Console.WriteLine(currentDay);  // outputs "Tuesday"

            Console.WriteLine((int)currentDay); // ouputs 2

            Console.ReadKey();
        }
        
    }
}
