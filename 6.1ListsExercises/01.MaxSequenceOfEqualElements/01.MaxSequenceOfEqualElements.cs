using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int number = 0;
            int maxCount = 1;
            //In order not to get our of the list we put Count -1, because beneath we are checking numbers [i + 1];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                //Check if the first number and the one next/after it are equals.
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    //Find the sequence from left to right.
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = numbers[i];
                    }
                }

                else
                {
                    count = 1;
                }
            }

            if (maxCount == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write($"{number} ");
                }
            }

        }
    }
}
