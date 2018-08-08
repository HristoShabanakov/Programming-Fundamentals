using System;
using System.Collections.Generic;
using System.Linq;



class ForceBook
{
    static void Main()
    {
        string command = Console.ReadLine();
        Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();
        while (command != "Lumpawaroo")
        {
            if (command.Contains("|"))
            {
                string[] info = command.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                //We put trim because name may consists of more than one word.
                string side = info[0].Trim();
                string name = info[1].Trim();
                //Check in Dictionary List is there user with this name,
                //if it exists we should add him
                //check if such forceUser already exists
                if (!forces.Values.Any(x => x.Contains(name)))
                {
                    if (!forces.ContainsKey(side))
                    {
                        forces.Add(side, new List<string>() { name });
                    }
                    //if exists we add him to the list.
                    else
                    {
                        forces[side].Add(name);
                    }
                }

            }
            else
            {
                string[] info = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = info[0].Trim();
                string side = info[1].Trim();
                //If the current forceSide does not exist we create it.
                if (!forces.ContainsKey(side))
                {
                    forces.Add(side, new List<string>());
                }
                if (forces.Values.Any(x => x.Contains(name)))
                {
                    foreach (var pair in forces)
                    {
                        if (pair.Value.Contains(name))
                        {
                            forces[pair.Key].Remove(name);
                        }
                    }
                }
                forces[side].Add(name);
                Console.WriteLine($"{name} joins the {side} side!");
            }

            command = Console.ReadLine();
        }
        //ordered descending by forceUsers count, than ordered by name
        foreach (var pair in forces.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            if (pair.Value.Count > 0)
            {
                Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
                //For each side print the forceUsers, ordered by name.
                foreach (var member in pair.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}



