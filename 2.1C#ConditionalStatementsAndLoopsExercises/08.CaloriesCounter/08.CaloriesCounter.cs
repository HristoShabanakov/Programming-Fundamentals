using System;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            
            int totalCaloriesAmount = 0;
            
            
            for (int i = 0; i <numberOfIngredients; i++)

            {
                
                switch (Console.ReadLine().ToLower())
                {
                    case "cheese":
                        totalCaloriesAmount += 500;
                        break;
                    case "tomato sauce":
                        totalCaloriesAmount += 150;
                        break;
                    case "salami":
                        totalCaloriesAmount += 600;
                        break;
                    case "pepper":
                        totalCaloriesAmount += 50;
                        break;
                }
                
            }
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
