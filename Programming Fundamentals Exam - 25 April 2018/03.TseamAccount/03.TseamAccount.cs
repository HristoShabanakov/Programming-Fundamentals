using System;
using System.Collections.Generic;
using System.Linq;


class TseamAccount
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        string[] commands = Console.ReadLine().Split(' ').ToArray();

        while (commands[0] != "Play!")
        {

            if (commands[0] == "Install")
            {
                string game = commands[1];
                if (!input.Contains(game))
                {
                    input.Add(game);
                }
            }

            else if (commands[0]== "Uninstall")
            {
                string game = commands[1];
                if (input.Contains(game))
                {
                    input.Remove(game);
                }
            }

            else if(commands[0] == "Update")
            {
                string game = commands[1];
                if (input.Contains(game))
                {
                    input.Remove(game);
                    input.Add(game);
                }
            }

            else if(commands[0] == "Expansion")
            {
                string game = commands[1];
                string Format;
                string[] Expansion = input[1].Split('-').Select(p => p.Trim()).ToArray();
                
                if (input.Contains(Expansion[0]))
                {
                    Format = $"{Expansion[0]}:{Expansion[1]}";
                    int index = 0;

                    for (int i = 0; i < input.Count; i++)
                    {
                        index = i;
                        break;
                    }
                    input.Insert(index + 1, Format);
                }
            }
            commands = Console.ReadLine().Split(' ').ToArray();
        }

        Console.WriteLine(string.Join(" ",input));
    }
}
