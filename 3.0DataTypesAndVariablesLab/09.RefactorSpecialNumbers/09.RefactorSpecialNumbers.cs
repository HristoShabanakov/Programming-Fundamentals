using System;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            int digitSum = 0;

            for (int i = 1; i <=n; i++)
            {
                currentNumber = i;

                while (i > 0)
                {
                    digitSum += i % 10;
                    i = i / 10;
                }

                bool magicNumber = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);

                Console.WriteLine($"{currentNumber} -> {magicNumber}");

                digitSum = 0;
                i = currentNumber;
            }
        }
    }
}
