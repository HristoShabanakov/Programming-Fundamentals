using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
        public static BigInteger Factorial(int factorial)
        {
            BigInteger factorialNumber = 1;
         //A factorial is a function that multiplies a number by every number below it. For example 5!= 5*4*3*2*1 = 120.

            for (int i = 1; i <= factorial; i++)
            {
                factorialNumber = factorialNumber * i;
            }

            return factorialNumber;
        }
    }
}
