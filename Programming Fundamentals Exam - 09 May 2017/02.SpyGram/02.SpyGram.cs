using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



class SpyGram
{
    static void Main()
    {
        string pattern = @"TO: ([A-Z])*; MESSAGE: (.*);";
        string key = Console.ReadLine();
        string input = Console.ReadLine();
        List<Match> messages = new List<Match>();

        while (input != "END")
        {
            if (Regex.IsMatch(input, pattern))
            {
                Match m = Regex.Match(input, pattern);
                messages.Add(m);
            }
            input = Console.ReadLine();
        }
        StringBuilder result = new StringBuilder();
        foreach (Match m in messages.OrderBy(x=>x.Groups[1].Value))
        {
            for (int i = 0; i < m.Value.Length; i++)
            {
                //we ran out of characters in the private key (example: 1,2,3,4,5) and rolled over to the start
                result.Append((char)(m.Value[i] + int.Parse(key[i % key.Length].ToString())));
            }
            Console.WriteLine(result);
            result.Clear();
        }
    }
}

