using System;

namespace SortingEngine
{
    class SortingEngine
    {
        static void Main(string[] args)
        {
            int[] numbers = Sort(10, 3, 2, -7, 18, 55, 48);
            PrintNumbers(numbers);
        }

        static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = 1 +i; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            }
            return numbers;
        }

        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
                if (i < (numbers.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
