using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                Dragon dragon = new Dragon();
                dragon.Type = commandArgs[0];
                dragon.Name = commandArgs[1];
                dragon.Damage = int.Parse(commandArgs[2]);
                dragon.Health = int.Parse(commandArgs[3]);
                dragon.Armor = int.Parse(commandArgs[4]);

                dragons.Add(dragon);

            }

            foreach (string dragonType in dragons.Select(d => d.Type).Distinct().ToList())
            {
                var averageDamage = dragons.Where(d => d.Type == dragonType).Average(d => d.Damage);
                var averageHealth = dragons.Where(d => d.Type == dragonType).Average(d => d.Health);
                var averageArmor = dragons.Where(d => d.Type == dragonType).Average(d => d.Armor);

                Console.WriteLine($"{dragonType}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragons.Where(d => d.Type == dragonType).OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }

        }
    }

    public class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
