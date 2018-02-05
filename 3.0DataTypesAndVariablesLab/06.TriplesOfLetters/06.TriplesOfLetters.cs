using System;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstChar = 0; firstChar < n; firstChar++)
            {
                for (int secondChar = 0; secondChar < n; secondChar++)
                {
                    for (int thirdChar = 0; thirdChar < n; thirdChar++)
                    {
                        char letter = (char)('a' + firstChar);
                        char letterTwo = (char)('a' + secondChar);
                        char letterThree = (char)('a' + thirdChar);
                        Console.WriteLine($"{letter}{letterTwo}{letterThree}");
                    }
                }
            }
        }
    }
}
