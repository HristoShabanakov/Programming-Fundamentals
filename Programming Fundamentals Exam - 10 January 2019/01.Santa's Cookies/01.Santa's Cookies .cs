using System;



class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cup = 140;
        int smallSpoon = 10;
        int bigSpoon = 20;
        int singleCookieGrams = 25;
        int cookiesPerBox = 5;
        int totalBoxes = 0;

        for (int i = 0; i < n; i++)
        {
            int flour = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            int cocoa = int.Parse(Console.ReadLine());

            int flourCups = flour / cup;
            int sugarSpoons = sugar / 20;
            int cocoaSpoons = cocoa / smallSpoon;
            int totalCookiesPerBake = (cup + smallSpoon + bigSpoon) * Math.Min(Math.Min(flourCups, sugarSpoons), cocoaSpoons) / singleCookieGrams;
            int boxesOfCookies = totalCookiesPerBake / cookiesPerBox;
            totalBoxes = boxesOfCookies + totalBoxes;

            if (boxesOfCookies > 0)
            {
                Console.WriteLine($"Boxes of cookies: {boxesOfCookies}");
            }
            else
            {
                Console.WriteLine("Ingredients are not enough for a box of cookies.");
            }
            
        }
        Console.WriteLine($"Total boxes: {totalBoxes}");
    }
}

