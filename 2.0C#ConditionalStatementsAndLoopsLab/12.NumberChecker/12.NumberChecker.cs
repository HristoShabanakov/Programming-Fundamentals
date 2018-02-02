using System;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
