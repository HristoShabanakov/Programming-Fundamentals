using System;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            int numberOfGivenIngredients = 0;
            int totalIngredients = 0;
            while (totalIngredients <= 20)
            {
                string ingredient = Console.ReadLine();
                
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numberOfGivenIngredients} ingredients.");
                    break;
                };

                Console.WriteLine($"Adding ingredient {ingredient}.");

                totalIngredients++;
                numberOfGivenIngredients++;
            }
        }
    }
}
