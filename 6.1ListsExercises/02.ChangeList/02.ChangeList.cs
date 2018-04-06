using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x)) //For each "X" element parse to int (Lambda function).
                .ToList();
            string input = Console.ReadLine();

            while (input != "Even" && input != "Odd")
            {

                string[] commands = input.Split(' ');

                switch (commands[0])
                //We took the first element of the array and check if is it "Delete or Insert".
                {
                    case "Delete":
                        int number = int.Parse(commands[1]);
                        //The second element of the array is for the input number.
                        numbers.RemoveAll(x => x == number);
                        break;

                    case "Insert":
                        
                        int element = int.Parse(commands[2]);
                        int numberPosition = int.Parse(commands[1]);
                        numbers.Insert(element, numberPosition);
                        break;
                }
                input = Console.ReadLine(); // with each rotation of the loop we have to read the input from the console.
            }

            if (input == "Odd")
            {
                //Print all odd numbers in the array separated with single whitespace
                Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0)));
            }

            if (input == "Even")
            {
                //Print all even numbers in the array separated with single whitespace, 
                //using again Lambda fuction in order to make the code more clear and efficient 
                Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
            Console.WriteLine();
        }
    }
}
