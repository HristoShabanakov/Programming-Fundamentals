using System;

namespace _02.CircleArea_Precision_12_
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * radius * radius:f12}");
        }
    }
}
