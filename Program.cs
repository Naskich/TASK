using System;

namespace CartesianCoordinateSystem
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Input numbers for 'x' and 'y' in Coordinate System ");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
                if (x == 0 && y == 0)
            {
                Console.WriteLine("Output {0}", 0);
            }
                 if (x > 0 && y > 0)
            {
                Console.WriteLine("Output {0}", 1);
            }
                 if (x < 0 && y > 0)
            {
                Console.WriteLine("Output {0}", 2);
            }
                if (x < 0 && y < 0)
            {
                Console.WriteLine("Output {0}", 3);
            }
                 if (x > 0 && y < 0)
            {
                Console.WriteLine("Output {0}", 4);
            }
                if (x == 0 && y > 0)
            {
                    Console.WriteLine("Output {0}", 5);
            }
                if (x > 0 && y == 0)
            {
                    Console.WriteLine("Output {0}", 6);
            }       
        }
    }
}
