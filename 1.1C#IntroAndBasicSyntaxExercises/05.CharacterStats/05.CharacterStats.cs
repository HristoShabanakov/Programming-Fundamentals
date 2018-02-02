using System;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main()
        {
            string Name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            string lineBarHealth = new string('|',currentHealth);
            string lineBarEnergy = new string('|',currentEnergy);

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {lineBarHealth}{"|"}{new string('.', maxHealth-currentHealth)}{"|"}");
            Console.WriteLine($"Energy: {lineBarEnergy}{"|"}{new string('.', maxEnergy-currentEnergy)}{"|"}");
            

            
            


        }
    }
}
