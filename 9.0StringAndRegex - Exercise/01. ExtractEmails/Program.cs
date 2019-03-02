using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //with this regex I am extracting all email address from a given text
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
