using System;

namespace _06.CalculateTriangleArea
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width, height);
            Console.WriteLine(area);
        }

        static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
