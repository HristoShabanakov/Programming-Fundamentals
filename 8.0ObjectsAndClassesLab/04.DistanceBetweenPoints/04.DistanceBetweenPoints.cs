using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main()
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

           double distance = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"Distance: {distance:f3}");
            
        }
        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            return Math.Sqrt(diffX * diffX + diffY * diffY);
        }

        static Point ReadPoint()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];
            return point;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    

   
}
