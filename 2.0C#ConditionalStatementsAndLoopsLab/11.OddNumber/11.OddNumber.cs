using System;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine($"Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            }
        }
    }
}
