using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToList();
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
            }

            if (result.Count < 1)
            {
                Console.WriteLine("Empty");
            }

            else
            {
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
