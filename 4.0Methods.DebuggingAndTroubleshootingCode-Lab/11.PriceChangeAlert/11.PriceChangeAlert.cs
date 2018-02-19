using System;

namespace _11.PriceChangeAlert
{
    class Program
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine());

            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double priceDifference = Percantage(lastPrice, price);

                bool GetSignificantDifference = GetPriceDifference(priceDifference, significanceThreshold);

                string message = GetStockPricesDifference(price, lastPrice, priceDifference, GetSignificantDifference);

                lastPrice = price;

                Console.WriteLine(message);
            }
        }

        private static string GetStockPricesDifference(double currentPrice, double lastPrice, double difference, bool hasSignificantDifference)

        {
            string priceInfo = "";
            if (difference == 0)
            {
                priceInfo = string.Format($"NO CHANGE: {currentPrice}");
            }
            else if (!hasSignificantDifference)
            {
                priceInfo = string.Format($"MINOR CHANGE: {lastPrice} to {currentPrice} ({difference * 100:F2}%)");
            }
            else if (hasSignificantDifference && (difference > 0))
            {
                priceInfo = string.Format($"PRICE UP: {lastPrice} to {currentPrice} ({difference * 100:F2}%)");
            }
            else if (hasSignificantDifference && (difference < 0))
                priceInfo = string.Format($"PRICE DOWN: {lastPrice} to {currentPrice} ({difference * 100:F2}%)");
            return priceInfo;
        }
        private static bool GetPriceDifference(double difference, double threshold)
        {
            if (Math.Abs(difference) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static double Percantage(double oldPrice, double newPrice)
        {
            double percentage = (newPrice - oldPrice) / oldPrice;
            return percentage;
        }
    }

}


