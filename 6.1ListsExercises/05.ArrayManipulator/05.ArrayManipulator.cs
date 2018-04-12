using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandsArgs = command.
                    Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (commandsArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandsArgs[1]), int.Parse(commandsArgs[2]));
                    //Instead of creating 2 variables we can direct implementation from the console with "int.parse";
                }

                else if (commandsArgs[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandsArgs[1]),
                        //We skip 2 elements (the command and the index are at the first 2 positions of "commandArgs")
                        commandsArgs.Skip(2).Select(int.Parse).ToArray());
                    // and take the rest of the elements
                }

                else if (commandsArgs[0] == "contains")
                {
                    int number = int.Parse(commandsArgs[1]);
                    //IndexOf() returns an index when the substring is found, but -1 if not. 
                    Console.WriteLine(numbers.IndexOf(number));
                }

                else if (commandsArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandsArgs[1]));
                }

                else if (commandsArgs[0] == "shift")
                {
                    int number = int.Parse(commandsArgs[1]);
                    number = number % numbers.Count;
                    var reminder = numbers.Take(number).ToList();
                    numbers.RemoveRange(0, number);
                    numbers.AddRange(reminder);
                }

                else if (commandsArgs[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }
    }
}
