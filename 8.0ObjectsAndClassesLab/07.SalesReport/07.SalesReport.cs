using System;
using System.Collections.Generic;

namespace _07.SalesReport
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }

            SortedDictionary<string,decimal> townSales = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!townSales.ContainsKey(sale.Town))
                {
                    townSales[sale.Town] = 0;
                }

                townSales[sale.Town] += sale.Price * sale.Quantity; 
            }

            foreach (var sale in townSales)
            {
                string town = sale.Key;
                decimal totalSales = sale.Value;

                Console.WriteLine($"{town} -> {totalSales:f2}");
            }
        }
        private static Sale ReadSale()
        {
            string[] items = Console.ReadLine().Split();

            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])

            };
        }
    }
}

public class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}