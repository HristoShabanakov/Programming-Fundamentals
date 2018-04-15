using System;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = numbers.Length;
            int k = length / 4;

            //Row 1, left part: take the first k numbers and reverse.
            int[] firstRowLeft = numbers.Take(k).Reverse().ToArray();
            //Row 1, right part: reverse and take the first k numbers.
            int[] firstRowRight = numbers.Reverse().Take(k).ToArray();
            //Concatenate the left and the right part of row 1.
            int[] concatenateFirstRow = firstRowLeft.Concat(firstRowRight).ToArray();
            //Row 2: skip the first k numbers and take the next 2*k numbers.
            int[] secondRow = numbers.Skip(k).Take(length / 2).ToArray();
            //Sum the arrays  = firstRowSelect ((x, index) => x + secondRow[index]).
            int[] arraysSum = concatenateFirstRow.Select((x, index) => x + secondRow[index]).ToArray();

            Console.WriteLine(string.Join(" ",arraysSum));
        }
    }
}
