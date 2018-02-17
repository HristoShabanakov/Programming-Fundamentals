using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumbers(number));
        }
        static int FibonacciNumbers(int n)
        {

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            // Fibonacci numbers are a useful pattern.
            {
                int temp = a;
                a = b;
                b = temp + b;
             //By storing the previous value in a loop iteration, we avoid computational work.
            }
            return b;
        }
    }
}
