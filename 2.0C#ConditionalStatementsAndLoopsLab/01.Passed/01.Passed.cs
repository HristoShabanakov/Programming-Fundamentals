using System;

namespace _01.Passed
{
    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
