using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesExercise2
{
    enum Direction { North, South, East, West }

    class Program
    {
        static void Main(string[] args)
        {
            List<Direction> directions = new List<Direction>();
            char input;

            do
            {
                Console.Write("Enter the next direction (n/s/e/w or 0 to finish): ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (input)
                {
                    case 'n':
                        directions.Add(Direction.North);
                        break;
                    case 's':
                        directions.Add(Direction.South);
                        break;
                    case 'e':
                        directions.Add(Direction.East);
                        break;
                    case 'w':
                        directions.Add(Direction.West);
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            } while (input != '0');

            Console.WriteLine($"\nYou entered {directions.Count} directions. The directions are as follows: ");

            foreach (Direction direction in directions)
            {
                Console.Write($"{ConvertDirectionToSymbol(direction)} ");
            }

            Console.ReadKey();
        }

        static string ConvertDirectionToSymbol(Direction direction)
        {
            switch(direction)
            {
                case Direction.North:
                    return "^";
                case Direction.South:
                    return "v";
                case Direction.East:
                    return ">";
                case Direction.West:
                    return "<";
                default:
                    return "";
            }
        }

    }
}
