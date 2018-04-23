using System;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);
                string reminder = words[index];
                int newIndex = rnd.Next(0, words.Length);
                words[index] = words[newIndex];
                words[newIndex] = reminder;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
