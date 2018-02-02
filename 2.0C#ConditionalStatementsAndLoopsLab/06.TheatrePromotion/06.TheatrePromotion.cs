using System;

namespace _06.TheatrePromotion
{
    class Program
    {
        static void Main()
        {
            string dayType = Console.ReadLine();
            int visitorAge =int.Parse(Console.ReadLine());
            int ticketPriceChildren = 0;
            int ticketPriceAdutls = 0;
            int ticketPriceSeniors = 0;

            switch (dayType)
            {
                case "Weekday":
                    ticketPriceChildren = 12;
                    ticketPriceAdutls = 18;
                    ticketPriceSeniors = 12;
                    break;
                case "Weekend":
                    ticketPriceChildren = 15;
                    ticketPriceAdutls = 20;
                    ticketPriceSeniors = 15;
                    break;
                case "Holiday":
                    ticketPriceChildren = 5;
                    ticketPriceAdutls = 12;
                    ticketPriceSeniors = 10;
                    break;
            }

            if(0 <= visitorAge && visitorAge <= 18)
            {
                Console.WriteLine($"{ticketPriceChildren}$");
            }
            else if(18 < visitorAge && visitorAge <= 64)
            {
                Console.WriteLine($"{ticketPriceAdutls}$");
            }
            else if(64 < visitorAge && visitorAge <= 122)
            {
                Console.WriteLine($"{ticketPriceSeniors}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
