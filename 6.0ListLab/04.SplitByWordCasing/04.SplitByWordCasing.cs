using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine() //Split the input text using the above described separators

            .Split(", ; : . ! ( ) \" ' \\ / [ ] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            //Create 3 lists of words (initially empty): lowercase words, mixed‐case words and uppercase words.
            List<string> lowercaseWords = new List<string>();
            List<string> uppercaseWords = new List<string>();
            List<string> mixedcaseWords = new List<string>();

            foreach (var word in words) //Process the obtained list of words one by one.

            {
                //Check each word and append it to one of the above 3 lists.
                if (word.All(char.IsLower))

                {
                    lowercaseWords.Add(word);
                }
                else if (word.All(char.IsUpper))

                {
                    uppercaseWords.Add(word);
                }
                else
                {
                    mixedcaseWords.Add(word);
                }
            }

            //Print the 3 lists.
            Console.WriteLine("Lower-case: " + string.Join(", ", lowercaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedcaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", uppercaseWords));
        }
    }
}
