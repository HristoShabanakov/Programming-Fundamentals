using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double,int> counts = new SortedDictionary<double, int>();

            foreach (var number in input)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }

                else
                {
                    counts[number] = 1;
                }
            }

            foreach (var number in counts.Keys)
            {
                Console.WriteLine($"{number} -> {counts[number]}");
            }

        }
    }
}
