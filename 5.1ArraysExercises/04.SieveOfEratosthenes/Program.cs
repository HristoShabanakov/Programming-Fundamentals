using System;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            bool[] arrayOfPrimes = new bool[numbers + 1];

            for (int i = 2; i < arrayOfPrimes.Length; i++)
            {
                arrayOfPrimes[i] = true;
            }

            for (int j = 0; j <=numbers; j++)
            {
                if (!arrayOfPrimes[j])
                {
                    continue;
                }

                else
                {
                    Console.Write(j +" ");
                }

                for (int k = 2 * j; k <=numbers; k+=j)
                {
                    arrayOfPrimes[k] = false;
                }
            }
            Console.WriteLine();
        }
    }
}
