using System;

namespace _02.VaporStore
{
    class Program
    {
        static void Main()
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine()); 
            //using decimal because you will receive a floating‐point number in the range [0.00…5000.00].
            string gameName = Console.ReadLine();
            decimal totalMoney = currentBalance;

            while (gameName != "Game Time") //Until you receive the command “Game Time”, you have to keep buying games.
            {
                
                switch (gameName)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                            Console.WriteLine("Too Expensive"); 
                  // if the user is trying to buy a game which they can’t afford, print “Too Expensive” and read the next line.

                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                            Console.WriteLine("Too Expensive");

                        break;
                    case "CS: OG":
                        if (currentBalance >= 15.99m)
                        {
                            currentBalance -= 15.99m;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                            Console.WriteLine("Too Expensive");
                        break;

                    case "Zplinter Zell":
                        if (currentBalance >= 19.99m)
                        {
                            currentBalance -= 19.99m;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                            Console.WriteLine("Too Expensive");

                        break;
                    case "Honored 2":
                        if (currentBalance >= 59.99m)
                        {
                            currentBalance -= 59.99m;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                            Console.WriteLine("Too Expensive");
                        break;

                    case "RoverWatch":
                        if (currentBalance >= 29.99m)
                        {
                            currentBalance -= 29.99m;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                            Console.WriteLine("Too Expensive");
                        break;

                    default:
                        Console.WriteLine("Not Found"); 
                        // If the user is trying to buy a game which is not present in the table above, print “Not Found”.
                        break;
                }

                if (currentBalance <= 0) //If at any point, the user has $0 left, print “Out of money!” and end the program.
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                
                gameName = Console.ReadLine();
                
            }
            decimal remainingMoney = totalMoney - currentBalance;

            Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${currentBalance:F2}");
        }
        // https://pastebin.com/MPiAsvep another solution with Dictionary.
    }
}
