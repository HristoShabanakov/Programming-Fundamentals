using System;
using System.Linq;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            char[] words = Console.ReadLine().ToLower().ToArray();

            foreach (char letter in words)
            {
                Console.WriteLine($"{letter} -> {letter - 97}");
            }
        }
    }
}
