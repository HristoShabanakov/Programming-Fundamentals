using System;
using System.Collections.Generic;
using System.Linq;


class HornetArmada
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> hornets = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, int> activities = new Dictionary<string, int>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { '-', '=', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int activity = int.Parse(input[0]);
            string legion = input[1];
            string soldierType = input[2];
            long soldierCount = long.Parse(input[3]);
            if (!activities.ContainsKey(legion))
            {
                activities.Add(legion, activity);
            }
            //IN BOTH cases, stated above, you should update the last activity, with the newly entered one, ONLY if the entered
            //one is GREATER than the previous one.
            else
            {
                if (activities[legion] < activity)
                {
                    activities[legion] = activity;
                }
            }
            //Standard way of filling an Nested dictionary!
            if (!hornets.ContainsKey(legion))
            {
                Dictionary<string, long> current = new Dictionary<string, long>();
                current.Add(soldierType, soldierCount);
                hornets.Add(legion, current);
            }
            //Nested dictionary means multi check ups
            else
            {
                if (!hornets[legion].ContainsKey(soldierType))
                {
                    hornets[legion].Add(soldierType, soldierCount);
                }
                else
                {
                    hornets[legion][soldierType] += soldierCount;
                }
            }
        }
        string[] command = Console.ReadLine()
            .Split(new char[] { '\\', ' ', }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        if (command.Length == 1)// if the input contains only one word
        {
            foreach (var pair in activities.OrderByDescending(x => x.Value))
            {
                if (hornets[pair.Key].ContainsKey(command[0]))
                {
                    Console.WriteLine($"{pair.Value} : {pair.Key}");
                }
            }
        }
        else
        {
            int act = int.Parse(command[0]);
            string type = command[1];
            //you must print all legions which have the given soldier type, with last activity, and legion name
            //The legions must be printed in descending order of their activity.
            foreach (var pair in hornets.Where(x => x.Value.ContainsKey(type)).OrderByDescending(x => x.Value[type]))
            {
                if (activities[pair.Key] < act)
                {
                    //pair.Value consists the whole dictionary, we want to print the numbers of soldiers only,
                    //thats why we access it : pair.Value[type].
                    Console.WriteLine($"{pair.Key} -> {pair.Value[type]}");
                }
            }
        }
    }
}

