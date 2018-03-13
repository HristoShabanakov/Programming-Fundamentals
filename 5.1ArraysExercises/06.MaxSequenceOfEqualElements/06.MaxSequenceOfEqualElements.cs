using System;
using System.Linq;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int bestcount = 0;
            int bestIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1]) 
               //we check if the previous number is equal to current number
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > bestcount)
                {
                    bestcount = count;
                    bestIndex = i - count + 1;
                }
            }

            for (int i = bestIndex; i < bestIndex + bestcount; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
