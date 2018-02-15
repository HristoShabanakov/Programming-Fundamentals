using System;

namespace PyramidWithMethods
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                PrintNumbers(1, i);
            }
            for (int j = n; j >=1; j--)
            {
                PrintNumbers(1, j);
            }
        }
        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <=end; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
