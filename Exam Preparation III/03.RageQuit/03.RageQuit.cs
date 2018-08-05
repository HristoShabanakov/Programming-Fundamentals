﻿using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



class RageQuit
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        foreach (Match m in Regex.Matches(input, @"([^0-9]+)(\d+)"))
        {
            string word = m.Groups[1].Value.ToUpper();
            int count = int.Parse(m.Groups[2].Value);

            for (int i = 0; i < count; i++)
            {
                result.Append(word);
            }
        }

        int uniqueChars = result.ToString().Distinct().Count();
        Console.WriteLine($"Unique symbols used: {uniqueChars}");
        Console.WriteLine(result.ToString());

    }
}

