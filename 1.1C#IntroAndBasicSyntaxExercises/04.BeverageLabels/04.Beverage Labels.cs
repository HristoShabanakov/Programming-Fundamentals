using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main()
        {
            string foodProductName = Console.ReadLine();
            int foodVolume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());
            double totalEnergy = foodVolume * energyContent /100.00;
            double totalSugar = foodVolume * sugarContent /100.00;

            Console.WriteLine($"{foodVolume}ml {foodProductName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
            
        }
    }
}
