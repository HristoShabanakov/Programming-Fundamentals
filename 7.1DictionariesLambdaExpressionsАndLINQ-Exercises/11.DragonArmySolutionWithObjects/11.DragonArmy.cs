using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Dragon> dragons = new List<Dragon>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Dragon dragon = CreateDragon(commandArgs);

                if (!dragons.Any(d => d.Name == dragon.Name && d.Type == dragon.Type))
                {   //We create the dragon with his stats :Type, Name, Damage, Health and Armor,
                    //and saving it directly to the List "dragon
                    dragons.Add(CreateDragon(commandArgs));
                }
                //If the same dragon is added a second time, the new stats should overwrite the previous ones. 
                //Two dragons are considered equal if they match by both name and type.
                else
                {
                    var reminder = dragons.FirstOrDefault(d => d.Name == dragon.Name && d.Type == dragon.Type);

                    if (commandArgs[2] != "null")
                    {
                        reminder.Damage = int.Parse(commandArgs[2]);
                    }
                    else
                    {
                        reminder.Damage = 45;
                    }

                    if (commandArgs[3] != "null")
                    {
                        reminder.Health = int.Parse(commandArgs[3]);
                    }

                    else
                    {
                        reminder.Health = 250;
                    }

                    if (commandArgs[4] != "null")
                    {
                        reminder.Armor = int.Parse(commandArgs[4]);
                    }
                    else
                    {
                        reminder.Armor = 10;
                    }
                }
            }
            //Categorize dragons by their type.
            foreach (string dragonType in dragons.Select(d => d.Type).Distinct().ToList())
            {
                var averageDamage = dragons.Where(d => d.Type == dragonType).Average(d => d.Damage);
                var averageHealth = dragons.Where(d => d.Type == dragonType).Average(d => d.Health);
                var averageArmor = dragons.Where(d => d.Type == dragonType).Average(d => d.Armor);
                //For each type print the average damage, health and armor of the dragons.
                Console.WriteLine($"{dragonType}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragons.Where(d => d.Type == dragonType).OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
        //With this method we are creating a Dragon and keep his info the in array of strings "commandArgs"
        public static Dragon CreateDragon(string[] commandArgs)
        {
            Dragon dragon = new Dragon();

            dragon.Type = commandArgs[0];
            dragon.Name = commandArgs[1];
            //If a stat is missing you should assign it default values. 
            //Default values are as follows: health 250, damage 45, and armor 10. 
            //Missing stat will be marked by null.
            if (commandArgs[2] != "null")
            {
                dragon.Damage = int.Parse(commandArgs[2]);
            }
            else
            {
                dragon.Damage = 45;
            }

            if (commandArgs[3] != "null")
            {
                dragon.Health = int.Parse(commandArgs[3]);
            }

            else
            {
                dragon.Health = 250;
            }

            if (commandArgs[4] != "null")
            {
                dragon.Armor = int.Parse(commandArgs[4]);
            }
            else
            {
                dragon.Armor = 10;
            }

            return dragon;
        }
    }


    public class Dragon
    //In the object Dragon we save the input in the following format {type} {name} {damage} {health} {armor}.
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }


}
