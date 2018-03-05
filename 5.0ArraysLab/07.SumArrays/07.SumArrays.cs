using System;
using System.Linq;

namespace _07.SumArrays
{
    class Program
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLenght = Math.Max(firstArray.Length, secondArray.Length);
            int [] sumOfArrays = new int[maxLenght];

            for (int i = 0; i < sumOfArrays.Length; i++)
            {
                sumOfArrays[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ", sumOfArrays));
        }
    }
}
