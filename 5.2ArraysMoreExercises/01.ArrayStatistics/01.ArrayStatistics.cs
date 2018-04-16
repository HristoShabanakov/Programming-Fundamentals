using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
             
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
