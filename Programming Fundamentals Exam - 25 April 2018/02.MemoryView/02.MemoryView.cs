using System;
using System.Collections.Generic;



class MemoryView
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;
        List<string> words = new List<string>();
        while(input!="Visual Studio crash")
        {
            result += input + " ";
            input = Console.ReadLine();
        }
        string[] tokens = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < tokens.Length -5; i++)
        {
            if(tokens[i]== "32656" && tokens[i +1]== "19759" && tokens[i +2] == "32763" && tokens[i + 3]  =="0" && tokens[i + 5]  == "0")
            {
                string word = string.Empty;
                int wordLength = int.Parse(tokens[i + 4]);

                for (int j = i + 6; j <= i + 6 + wordLength; j++)
                {
                    word += (char)(int.Parse(tokens[j]));
                }
                words.Add(word);
            }
        }
        Console.WriteLine(string.Join("\n",words));
    }
}

