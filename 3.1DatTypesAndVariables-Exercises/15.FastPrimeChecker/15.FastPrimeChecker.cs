using System;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            //A prime number has no divisors (other than itself and 1). 
            for (int i = 2; i <= number; i++)
            {
                bool isItPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i % j == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isItPrime}");
            }
        }
    }
}
