using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalTime = (hours *3600 + minutes * 60 + seconds);
            float metersPerSecond = distanceInMeters / totalTime;
            float kmPerHour = (distanceInMeters / 1000) / (totalTime / 3600);
            float milesPerHour = (distanceInMeters /1609) / (totalTime / 3600);

            Console.WriteLine($"{metersPerSecond:F6}");
            Console.WriteLine($"{kmPerHour:F6}");
            Console.WriteLine($"{milesPerHour:F6}");
        }
    }
}
