using System;


class SplinterTrip
{
    static void Main()
    {
        double miles = double.Parse(Console.ReadLine());
        double capacity = double.Parse(Console.ReadLine());
        double heavyWinds = double.Parse(Console.ReadLine());
        double fuelConsumption = (miles - heavyWinds) * 25;
        double heavyWindsConsumption = heavyWinds * (25 * 1.5);
        double totalFuelConsumption = fuelConsumption + heavyWindsConsumption;
        double tolerance = totalFuelConsumption + (totalFuelConsumption * 0.05);
        double remainingFuel = capacity - tolerance;


        Console.WriteLine($"Fuel needed: {tolerance:f2}L");
        if (tolerance <= capacity)
        {
            Console.WriteLine($"Enough with {remainingFuel:f2}L to spare! ");
        }
        else
        {
            Console.WriteLine($"We need {Math.Abs(remainingFuel):f2}L more fuel.");
        }

    }
}

