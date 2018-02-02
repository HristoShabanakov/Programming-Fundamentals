using System;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main()
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());



            if (numberB - numberA < 4) // If the difference between the two numbers is bigger than four the program will execute.
            {
                Console.WriteLine("No");
            }
            {
                for (int i = numberA; i <= numberB; i++) // For each number we have one loop assigned.
                {
                    for (int j = numberA; j <= numberB; j++)
                    {
                        for (int k = numberA; k <= numberB; k++)
                        {
                            for (int l = numberA; l <= numberB; l++)
                            {
                                for (int m = numberA; m <= numberB; m++)
                                {
                                    if (i < j && j < k && k < l && l < m) //// printing the five numbers for which the following condition is true :
                                        Console.WriteLine($"{i} {j} {k} {l} {m}"); //  a ≤ n1 < n2 < n3 < n4 ≤ n5 ≤ b
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
