using System;
using System.Collections.Generic;
using System.Linq;



class CODEPhoenixOscarRomeoNovember
{
    static void Main()
    {
        Dictionary<string, List<string>> mates = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "Blaze it!")
        {
            string[] info = input
            .Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            string creature = info[0];
            string mate = info[1];

            if (!mates.ContainsKey(creature))
            {
                List<string> friends = new List<string>();
                friends.Add(mate);
                mates.Add(creature, friends);
            }
            else
            {
                //If there is already a squad mate with the given name in the given creature’s squad,
                //IGNORE that line of input.
                if (!mates[creature].Contains(mate) && mate != creature)
                {
                    mates[creature].Add(mate);
                }

            }
            input = Console.ReadLine();
        }
        //The foreach will pass through each couple (string and List<string>) of the dictionary.
        foreach (var pair in mates)
        {
            //The for loop will pass through the whole List<string>.
            for (int i = 0; i < pair.Value.Count; i++)
            {
                if (mates.ContainsKey(pair.Value[i]))
                {
                    if (mates[pair.Value[i]].Contains(pair.Key))
                    {
                        mates[pair.Value[i]].Remove(pair.Key);
                        mates[pair.Key].Remove(pair.Value[i]);
                        //!!When we are deleting elements from the list we are decreasing its length
                        //so we have to decrease the length of "for loop" in order to keep the balance!!
                        i--;
                    }
                }
            }
        }

        foreach (var pair in mates.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{pair.Key} : {pair.Value.Count}");
        }
    }
}

