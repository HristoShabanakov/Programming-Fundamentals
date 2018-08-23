using System;
using System.Collections.Generic;
using System.Linq;



class NSA
{
    static void Main()
    {
        string command = Console.ReadLine();
        Dictionary<string, Dictionary<string, int>> spies = new Dictionary<string, Dictionary<string, int>>();
        while (command != "quit")
        {
            string[] info = command.Split(new[] { " -> " }, StringSplitOptions.None).ToArray();
            string country = info[0];
            string name = info[1];
            int days = int.Parse(info[2]);

            if (!spies.ContainsKey(country))
            {
                Dictionary<string, int> current = new Dictionary<string, int>();
                current.Add(name, days);
                spies.Add(country, current);
            }
            else
            {
                //If you get an existent country, add the new spy to it.
                if (!spies[country].ContainsKey(name))
                {
                    spies[country].Add(name, days);
                }
                //If even the spy exists, update its days InService, with the new given value.
                else
                {
                    spies[country][name] = days;
                }
            }

            command = Console.ReadLine();
        }

        foreach (var pair in spies.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"Country: {pair.Key}");

            foreach (var item in pair.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"**{item.Key} : {item.Value}");
            }
        }
    }
}

