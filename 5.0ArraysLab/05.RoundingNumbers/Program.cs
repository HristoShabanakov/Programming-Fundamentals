using System;
using System.Linq;

namespace _05.RoundingNumbers
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().
                Split(' ').
                Select(double.Parse).
                ToArray();

            foreach (var number in numbers)
            {
                double rounded = Math.Round(number, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine(number + " =>" + rounded);
            }
        }
    }
}
