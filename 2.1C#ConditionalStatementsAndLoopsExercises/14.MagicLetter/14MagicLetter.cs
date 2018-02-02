using System;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine()); // the input is letters only, so we have to use char
            char secondLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        string currentSequence = "" + i + j + k;
                        if(!currentSequence.Contains(skipLetter + "")) //every combination which contains the skipping letter should not be printed
                        {
                            Console.Write(currentSequence + " ");
                        }
                    }
                }
            }
        }
    }
}
