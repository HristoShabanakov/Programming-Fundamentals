using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int,int> counts = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }
                counts[number]++;
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
