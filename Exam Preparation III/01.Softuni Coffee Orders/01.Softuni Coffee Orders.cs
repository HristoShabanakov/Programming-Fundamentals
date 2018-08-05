using System;

class SoftuniCoffeeOrders
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;
        for (int i = 0; i < n; i++)
        {
            decimal price = ReadAndCalculatePrice();
            totalPrice += price;
        }
        Console.WriteLine($"Total: ${totalPrice:f2}");
    }

    static decimal  ReadAndCalculatePrice()
    {
        decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
        string dateStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateStr,"d/M/yyyy",null);
        decimal capsulesCount = decimal.Parse(Console.ReadLine());
        decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
        decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
        Console.WriteLine($"The price for the coffee is: ${price:f2}") ;

        return price;
    }

}
