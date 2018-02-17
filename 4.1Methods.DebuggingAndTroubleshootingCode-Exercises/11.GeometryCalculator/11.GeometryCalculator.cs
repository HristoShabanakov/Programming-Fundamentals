using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if(input == "triangle")
            {
                GetTriangleArea();
            }
            else if (input == "square")
            {
                GetSquareArea();
            }
            else if(input == "rectangle")
            {
                GetRectangleArea();
            }
            else if (input == "circle")
            {
                GetCircleRadius();
            }
           
        }
        static void GetTriangleArea()
        {
           double side = double.Parse(Console.ReadLine());
           double height = double.Parse(Console.ReadLine());
           double area = (side * height) / 2;
           Console.WriteLine($"{area:f2}");
        }

        static void GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:f2}");
        }

        static void GetRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double area = width * heigth;
            Console.WriteLine($"{area:f2}");
        }

        static void GetCircleRadius()
        {
            double circumference = double.Parse(Console.ReadLine());
            double radius = Math.PI * Math.Pow(circumference,2);
            Console.WriteLine($"{radius:f2}");
        }
        
    }
}
