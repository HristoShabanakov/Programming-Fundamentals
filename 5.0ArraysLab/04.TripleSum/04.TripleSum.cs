using System;
using System.Linq;

namespace _04.TripleSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int firstNumber = 0;
            int secondNumber = 0;
            int tripleSum = 0;

            bool containsTriple = false;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    firstNumber = numbers[i];
                    secondNumber = numbers[j];
                    tripleSum = firstNumber + secondNumber;

                    if (numbers.Contains(tripleSum))
                    {
                        containsTriple = true;
                        Console.WriteLine($"{firstNumber} + {secondNumber} == {tripleSum}");
                    }
                }
            }

            if (!containsTriple)
            {
                Console.WriteLine("No");
            }
        }
    }
}
