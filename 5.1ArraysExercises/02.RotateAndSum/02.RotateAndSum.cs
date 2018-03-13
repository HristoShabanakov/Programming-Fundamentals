using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotate = int.Parse(Console.ReadLine());

            int[] sum = new int[arrayOfNumbers.Length];

            for (int i = 0; i < rotate; i++)
            {
                RotateArrya(arrayOfNumbers);

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + arrayOfNumbers[j];
                }
            }

            Console.WriteLine(string.Join(" ",sum));
        }

        private static void RotateArrya(int[] arrayOfNumbers)
        {
            int lastNumber = arrayOfNumbers.Last();

            for (int i = arrayOfNumbers.Length-1; i > 0; i--)
            {
                arrayOfNumbers[i]=arrayOfNumbers[i-1];
            }
            arrayOfNumbers[0] = lastNumber;
        }
    }
}
