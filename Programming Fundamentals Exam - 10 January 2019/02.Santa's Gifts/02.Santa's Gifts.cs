using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for (int i = 0; i < n; i++)
        {
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            string command = commands[0];
            int currentPosition = 0;

            switch (command)
            {
                case "Forward":
                    int steps = int.Parse(commands[1]);
                    
                    input.RemoveAt(steps);
                   
                    break;

                case "Back":
                    int backSteps = int.Parse(commands[1]);
                    
                    break;

                case "Swap":

                    int valueOne = int.Parse(commands[1]);
                    int valueTwo = int.Parse(commands[2]);

                    input.Select(x => x == valueOne && x == valueTwo);
                    
                    
                    break;

                case "Gift":
                    int index = int.Parse(commands[1]);
                    int value = int.Parse(commands[2]);
                    input.Insert(index, value);
                    
                    break;
            }

        }
        Console.WriteLine($"Position: ");
        Console.WriteLine(string.Join(", ", input));
    }
    static void SwapInts(List<int> array, int valueOne, int valueTwo)
    {

        int temp = array[valueOne]; // Copy the first position's element
        array[valueOne] = array[valueTwo]; // Assign to the second element
        array[valueTwo] = temp; // Assign to the first element
    }
}

