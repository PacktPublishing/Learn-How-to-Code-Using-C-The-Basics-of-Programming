using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Point Point1 = new Point();
            Point Point2 = new Point();
            double distance;

            Console.Write("Enter the x coordinate for point 1: ");
            Point1.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 1: ");
            Point1.Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the x coordinate for point 2: ");
            Point2.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y coordinate for point 2: ");
            Point2.Y = Convert.ToInt32(Console.ReadLine());

            distance = CalculateDistance(Point1, Point2);

            Console.WriteLine();
            Console.WriteLine($"The distance between these two points is {distance.ToString("F")}");

            Console.ReadKey();
        }

        static double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }

    }
}
