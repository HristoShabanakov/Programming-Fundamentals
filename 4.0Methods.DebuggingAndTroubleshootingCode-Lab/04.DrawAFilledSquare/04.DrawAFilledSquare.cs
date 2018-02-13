using System;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            DrawHeader(n);
            DrawMiddlePart(n);
            DrawFooter(n);
        }

        static void DrawHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void DrawMiddlePart(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        static void DrawFooter(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
