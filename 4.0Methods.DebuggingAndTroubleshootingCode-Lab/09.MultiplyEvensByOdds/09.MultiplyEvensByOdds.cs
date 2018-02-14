using System;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if(lastDigit % 2 != 0)
                {
                    sum +=lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if(lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
