using System;
using System.Linq;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main()
        {
            long result = Console.ReadLine()
            .Split()
            .Select(a => int.Parse(new string(a.Reverse()
            .ToArray())))
            .Sum();

            Console.WriteLine(result);

        }
    }
}