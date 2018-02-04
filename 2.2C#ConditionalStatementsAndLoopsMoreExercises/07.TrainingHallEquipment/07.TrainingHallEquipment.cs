using System;

namespace _07.Training
{
    class Program
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            decimal subtotal = 0;
            for (int i = 0; i < numberOfItems; i++)

            {
                string itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                decimal itemCount = decimal.Parse(Console.ReadLine());
                decimal totalPrice = itemPrice * itemCount;
                subtotal += totalPrice;

                if (itemCount % 2 == 0) //if the item count isn’t 1, add an S at the end of the item name
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
            }

            if (budget > subtotal)
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Money left: ${budget - subtotal:F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Not enough. We need ${subtotal - budget:F2} more.");
            }
        }
    }
}
