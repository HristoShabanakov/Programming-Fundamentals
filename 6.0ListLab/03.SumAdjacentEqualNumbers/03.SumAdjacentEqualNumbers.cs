using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();


            bool hasSummed = true; //In this variable we keep the current condition.

            while (hasSummed)
            {
                hasSummed = false;

                int index = 0;
                decimal sum = 0;

                for (int i = 1; i < numbers.Count; i++)
                //Pass through each number and compare with the previous number.
                //If we find to equal numbers, we keep their Index and Sum
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        index = i - 1;
                        sum = numbers[i] + numbers[i - 1];
                        hasSummed = true;
                        break;
                    }
                }

                if (hasSummed)
                //Remove two numbers of the current Index and Insert at his position the Sum of the numbers.
                {
                    numbers.RemoveRange(index, 2);
                    numbers.Insert(index, sum);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
