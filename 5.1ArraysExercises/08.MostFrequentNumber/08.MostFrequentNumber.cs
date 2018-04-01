using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int frequentNumber = numbers.GroupBy(n => n)
                .OrderByDescending(n => n.Count())
                .First()
                .Key;

            Console.WriteLine(frequentNumber);
        }
    }
}
