using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()

    {
        Dictionary<string, int> children = new Dictionary<string, int>();
        Dictionary<string, int> presents = new Dictionary<string, int>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] info = input.Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (info[0] == "Remove")
            {
                string child = info[1];
                children.Remove(child);
            }
            else
            {
                string childName = info[0];
                string typeOfPresent = info[1];
                int points = int.Parse(info[2]);

                if (!children.ContainsKey(childName))
                {
                    children.Add(childName, points);
                }
                else
                {
                    children[childName] += points;
                }

                if (!presents.ContainsKey(typeOfPresent))
                {
                    presents.Add(typeOfPresent, points);

                }
                else
                {
                    presents[typeOfPresent] += points;
                }
            }
        }

        Console.WriteLine("Children:");
        foreach (var pair in children.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
        {
          Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }

        Console.WriteLine("Presents:");
        foreach (var pair in presents)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

