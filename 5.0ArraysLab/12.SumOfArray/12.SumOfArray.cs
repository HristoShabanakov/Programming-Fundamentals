using System;
using System.Linq;

namespace _12.SumOfArray
{
    class Program
    {
        static void Main()
        {
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(items.Sum());
        }
    }
}
