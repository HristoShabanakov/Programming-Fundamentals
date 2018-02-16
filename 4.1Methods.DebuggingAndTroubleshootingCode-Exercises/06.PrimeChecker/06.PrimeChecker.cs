using System;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(input));
        }
        static bool IsPrime(long n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
