using System;
using System.Collections.Generic;
using System.Linq;


class Trainlands
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();
        string command = Console.ReadLine();

        while (command != "It's Training Men!")
        {
            //We have to split only by space, because there are 3 diffirent types of inputs.
            //If we split by new char[] { ' ', '-', ':', '>', '='}, we wont be able to distinguish
            //the different input cases.
            string[] info = command.Split(' ');
            //Input Example:
            //Kivil -> KAKA : 1387
            if (info.Length == 5)
            {
                string name = info[0];
                string wagon = info[2];
                int Power = int.Parse(info[4]);

                //Creates a train with the given name and adds a wagon to it with the given name and power.
                if (!trains.ContainsKey(name))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(wagon, Power);
                    trains.Add(name, current);
                }

                else
                {//If the train already exists, it just adds the given wagon to it.
                    if (!trains[name].ContainsKey(wagon))
                    {
                        trains[name].Add(wagon, Power);
                    }
                }
            }
            else if (info[1] == "->")
            //Zone -> Kivil
            {
                string first = info[0];
                string other = info[2];

                if (!trains.ContainsKey(first))
                //If the first train does NOT exist, create it, and then add the wagons.
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    trains.Add(first, current);
                }

                foreach (var pair in trains[other])
                //Adds all of the wagons from the other train to the first train
                {
                    trains[first].Add(pair.Key, pair.Value);
                }
                //and REMOVES the other train.
                trains.Remove(other);
            }
            else
            //Daun = Anna
            {
                string first = info[0];
                string other = info[2];

                if (!trains.ContainsKey(first))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    trains.Add(first, current);
                }
                trains[first].Clear();
                //Copies the other train’s wagons, without affecting the other train. 
                //Copying means, that the first train’s wagons
                //become the same as the other train’s wagons.
                foreach (var pair in trains[other])
                {
                    trains[first].Add(pair.Key, pair.Value);
                }
            }
            command = Console.ReadLine();
        }
        foreach (var train in trains.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Values.Count))
            //The trains must be ordered by total wagon power, in descending order, 
            //and by wagon count in ascending order as secondary criteria.
        {
            Console.WriteLine($"Train: {train.Key}");

            foreach (var item in train.Value.OrderByDescending(x => x.Value))
            //For each train you should print its wagons, ordered by wagon power in descending order.
            {
                Console.WriteLine($"###{item.Key} - {item.Value}");
            }
        }
    }
}
