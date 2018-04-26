using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);
            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);

        }

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        static Point ReadPoint()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = input[0];
            point.Y = input[1];
            return point;
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"{point.X} {point.Y}");
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalculateDistance(points[0], points[1]);
            Console.WriteLine($"{distance}");
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
            return Math.Sqrt(diffX * diffX + diffY * diffY);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int firstPoint = 0; firstPoint < points.Length; firstPoint++)
            {
                for (int secondPoint = firstPoint +1; secondPoint < points.Length; secondPoint++)
                {
                    double distance = CalculateDistance(points[firstPoint], points[secondPoint]);
                    if(distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[firstPoint], points[secondPoint] };
                    }
                }
            }
            return closestTwoPoints;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
