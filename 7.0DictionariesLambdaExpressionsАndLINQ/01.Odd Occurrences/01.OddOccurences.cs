using System;
using System.Collections.Generic;

namespace _01.Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            
            var sequenceOfWords = new Dictionary<string, int>();

            foreach (var word in input) 
            {
                if (sequenceOfWords.ContainsKey(word))
                {
                    sequenceOfWords[word]++;
                }
                else
                {
                    sequenceOfWords[word] = 1;
                }
            }

            var oddCount = new List<string>(); // creating a new list which will store the odd count

            foreach (var pair in sequenceOfWords)
            {
                if(pair.Value % 2 == 1)
                {
                    oddCount.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(" ",oddCount)); //print the list

        }
    }
}
