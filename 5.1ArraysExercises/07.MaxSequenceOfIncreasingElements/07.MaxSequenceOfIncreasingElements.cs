using System;
using System.Linq;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] > numbers[i - 1])
                {
                    count++;
                }

                else
                {
                    count = 1;
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    bestIndex = i - count + 1;
                }
            }

            for (int i = bestIndex; i < bestIndex + bestCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
