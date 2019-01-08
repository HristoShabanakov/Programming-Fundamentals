using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Dwarf> dwarves = new List<Dwarf>();
        string line = string.Empty;

        while ((line = Console.ReadLine()) != "Once upon a time")
        {
            string[] tokens = line.Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            string color = tokens[1];
            int physics = int.Parse(tokens[2]);

            if (dwarves.Where(x => x.Name == name && x.Color == color).Count() > 0)
            {
                int currentDwarfPhysics = dwarves
                    .FirstOrDefault(x => x.Name == name && x.Color == color)
                    .Physics;

                if (physics > currentDwarfPhysics)
                {
                    dwarves
                        .FirstOrDefault(x => x.Name == name && x.Color == color)
                        .Physics = physics;
                }
            }
            else
            {
                dwarves.Add(new Dwarf(name, color, physics));
            }
        }

        foreach (Dwarf dwarf in dwarves
            .OrderByDescending(x => x.Physics)
            .ThenByDescending(x => dwarves.Where(j => j.Color == x.Color)
            .Count()))
        {
            Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
        }
    }
}
public class Dwarf
{
    public string Name { get; set; }

    public string Color { get; set; }

    public int Physics { get; set; }

    //Creating consturctor
    public Dwarf(string name, string color, int physics)
    {
        this.Name = name;
        this.Color = color;
        this.Physics = physics;
    }
}

