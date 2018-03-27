using System;
using System.Linq;

namespace _03.FoldAndSumLinq
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int length = input.Length;
            int k = length / 4;
            int[] firstSetOfNumbers = input.Take(k).Reverse().ToArray();
            int[] secondSetOfNumbers = input.Reverse().Take(k).ToArray();

            int[] firstRow = firstSetOfNumbers.Concat(secondSetOfNumbers).ToArray();
            int[] secondRow = input.Skip(k).Take(length / 2).ToArray();

            int[] sum = firstRow.Zip(secondRow, (x, y) => x + y).ToArray();
            
            Console.WriteLine(string.Join(" ",sum));
            
        }
    }
}
