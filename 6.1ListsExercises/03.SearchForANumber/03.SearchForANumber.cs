using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //.Take method allows you to get the first several elements from a sequence.
            List<int> result = numbers.Take(commands[0]).ToList();

            //.RemoveRange it will remove all elements starting from Zero, until the number we enter from the console "commands".
            result.RemoveRange(0, commands[1]);

            //.Contains is an instance method—you can call it on a specific string in your program. 
            //It has a bool result, which is true if the parameter is found, and false if it is not found.
            Console.WriteLine(result.Contains(commands[2]) ? "YES!" : "NO!");
             

            
        }
    }
}
