using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();
            string hallName = "";
            double hallPrice = 0;
            bool ofLimit = false;

            if (groupSize <= 50)
            {
                hallPrice = 2500;
                hallName="Small Hall";
            }
            else if (groupSize > 50 & groupSize <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (groupSize > 100 & groupSize <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                ofLimit = true;
            }

            switch (servicePackage)
            {
                case "Normal":
                    hallPrice += 500;
                    hallPrice = (hallPrice - (hallPrice * 0.05)) / groupSize;
                    break;

                case "Gold":
                    hallPrice += 750;
                    hallPrice = (hallPrice - (hallPrice * 0.10)) / groupSize;
                    break;

                case "Platinum":
                    hallPrice += 1000;
                    hallPrice = (hallPrice - (hallPrice * 0.15)) / groupSize;
                    break;
            }

            if (!ofLimit)
            {
                Console.WriteLine($"We can offer you the {hallName}\nThe price per person is {hallPrice:f2}$");
            }

        }
    }
}
