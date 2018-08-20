using System;
using System.Collections.Generic;
using System.Linq;


class TseamAccount
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();

        while (true)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            if (commands[0] == "Play!")
            {
                break;
            }
            //If you receive Install command, you should add the game at last position in the account, 
            //but only if it isn`t installed already.
            if (commands[0] == "Install")
            {
                
                if (!input.Contains(commands[1]))
                {
                    input.Add(commands[1]);
                }
            }
            //If you receive Uninstall command, delete the game if it exists.
            if (commands[0]== "Uninstall")
            {
               
                if (input.Contains(commands[1]))
                {
                    input.Remove(commands[1]);
                }
            }
            //If you receive Update command, you should update the game if it exists and place it on last position.
            if (commands[0] == "Update")
            {
                
                if (input.Contains(commands[1]))
                {
                    input.Remove(commands[1]);
                    input.Add(commands[1]);
                }
            }
            //If you receive Expansion command, you should check if the game exists
            //and insert after it the expansion in the following format: "{game}:{expansion}";
            if (commands[0] == "Expansion")
            {
                string Format;
                string[] Expansion = commands[1].Split('-').Select(p => p.Trim()).ToArray();
                
                if (input.Contains(Expansion[0]))
                {
                    Format = $"{Expansion[0]}:{Expansion[1]}";
                    int index = 0;

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == Expansion[0])
                        {
                            index = i;
                            break;
                        }
                    }
                    input.Insert(index + 1, Format);
                }
            }
        }
        Console.WriteLine(string.Join(" ",input));
    }
}
