using System;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object sentence = firstWord + " " + secondWord;
            string completeSentence = (string)sentence;
            Console.WriteLine(completeSentence);
        }
    }
}
