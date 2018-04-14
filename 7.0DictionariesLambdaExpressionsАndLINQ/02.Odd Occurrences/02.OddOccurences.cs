using System;
using System.Collections.Generic;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            
            var sequenceOfWords = new Dictionary<string, int>();

            foreach (var word in input)
            //Counting the words :java php php java java
            {   //java | 3
                //php | 2
                {
                    if (sequenceOfWords.ContainsKey(word))
                    //if the current word exists we are increasing its count
                    {
                        sequenceOfWords[word]++;
                }
                else
                    //we have found a new word which we encounter for the first time 
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
