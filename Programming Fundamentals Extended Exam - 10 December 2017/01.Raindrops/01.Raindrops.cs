using System;
using System.Linq;



class Raindrops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double density = double.Parse(Console.ReadLine());
        double total = 0;
        for (int i = 0; i < n; i++)
        {
            string[] regions = Console.ReadLine().Split(' ').ToArray();
            long raindropsCount = long.Parse(regions[0]);
            int squareMeters = int.Parse(regions[1]);
            //We have to integers and when divided them the result will be integer, not a floating point number.
            //So we multiply by 1.0 in order to get a floating poing number as result.
            double regionalcoefficient = raindropsCount * 1.0 / squareMeters;
            total += regionalcoefficient;
        }
        
        if (density!=0)
        {
            Console.WriteLine($"{total / density:f3} ");
        }
        else
        {
            Console.WriteLine($"{total:f3}");
        }
    }
}

