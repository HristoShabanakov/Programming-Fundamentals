using System;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double milesToKm = miles * 1.60934;

            Console.WriteLine($"{milesToKm:F2}");
        }
    }
}
