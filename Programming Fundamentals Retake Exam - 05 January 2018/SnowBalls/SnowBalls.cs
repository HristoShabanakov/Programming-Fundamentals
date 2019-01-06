using System;
using System.Numerics;

class SnowBalls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxsnowballSnow = 0;
        int maxsnowballTime = 0;
        int maxsnowballQuality = 0;
        BigInteger maxSnowballValue = 0;

        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

            if (snowballValue > maxSnowballValue)
            {
                maxSnowballValue = snowballValue;
                maxsnowballSnow = snowballSnow;
                maxsnowballTime = snowballTime;
                maxsnowballQuality = snowballQuality;
            }
        }
        Console.WriteLine($"{maxsnowballSnow} : {maxsnowballTime} = {maxSnowballValue} ({maxsnowballQuality})");
    }
}

