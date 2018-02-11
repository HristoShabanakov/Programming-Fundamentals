using System;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        static void PrintLine(int start, int end) //Creating a method which prints a single line of the figure
        {
            for (int i = start; i <=end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n) 
        //Creating a second method which prints the first half of the figure with one for loop,
        //and then the second part of the figure with second for loop.
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }

            for (int i = n-1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
