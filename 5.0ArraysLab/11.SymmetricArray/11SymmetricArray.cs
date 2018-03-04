using System;

namespace _11.SymmetricArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[n - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }

            Console.WriteLine($"Is symmetric? {symmetric}");
        }
    }
}
