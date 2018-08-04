﻿using System;
using System.Linq;

namespace _02.KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] array = new int[lenght];
            int[] result = new int[lenght];

            int bestIndex = 0;
            int iteration = 1;
            int bestIteration = 1;
            int bestCounter = 0;

            while (input != "Clone them!")
            {
                array = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int counter = 0;
                int startIndex = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    int current = array[i];

                    if (current == 1)
                    {
                        counter++;

                        if (bestCounter < counter)
                        {
                            bestCounter = counter;
                            result = array;
                            bestIteration = iteration;
                            bestIndex = startIndex;
                        }

                        if (bestCounter == counter && bestIndex > startIndex)
                        {
                            bestCounter = counter;
                            result = array;
                            bestIteration = iteration;
                            bestIndex = startIndex;
                        }

                        else if (bestCounter == counter && array.Sum() > result.Sum())
                        {
                            bestCounter = counter;
                            result = array;
                            bestIteration = iteration;
                            bestIndex = startIndex;
                        }
                    }

                    else
                    {
                        counter = 0;
                        startIndex = i + 1;
                    }
                }
                iteration++;

                input = Console.ReadLine();
            }

            Console.Write($"Best DNA sample {bestIteration} with sum: ");
            Console.WriteLine(string.Join(" ", result.Sum()) + ".");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
