using System;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int greaterNumber = GetMax(firstNumber, secondNumber);
                Console.WriteLine(greaterNumber);
            }
            else if (input == "char")
            {
                char firstCharacter = char.Parse(Console.ReadLine());
                char secondCharacter = char.Parse(Console.ReadLine());
                char finalCharacter = GetMax(firstCharacter,secondCharacter);
                Console.WriteLine(finalCharacter);
            }
            else if(input == "string")
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();
                string longerWord = GetMax(firstWord, secondWord);
                Console.WriteLine(longerWord);
            }
        }

        static int GetMax(int firstNumber, int secondNumber) //Method which compare integers.
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber; //Returns the highest value between two integers.
            }
            else if(secondNumber>=firstNumber)
            {
                return secondNumber;
            }
            int max = Math.Max(firstNumber, secondNumber);
            //Math.Max - receives two numbers and returns the larger of the two arguments. 
            return max;
        }

        static char GetMax(char charA, char CharB) //This method will compare chars
        {
            ushort greaterCharacter = Math.Max(charA, CharB);
            //Often in algorithms we need to test if an integer is less than zero. We use Math.Max to test for these conditions with less code.
            //Math.Max can be used to specify, in a single statement, a maximum value. It can encode a constraint, replacing an if-statement.
            return (char)greaterCharacter;
        }

        static string GetMax(string firstString, string secondString) //This method will compare string
        {
            string finalString = string.Empty; 

            if (firstString.CompareTo(secondString) >= 0)
                //Strings cannot be compared with operators '>' and '<', so we need to use the Method "CompareTo", which returns
                //an integer value (greater than zero if the compared object is greater, less than zero if the compared object is lesser 
                //and zero if the two objects are equal.
            {
                finalString = firstString;
            }
            else
            {
                finalString = secondString;
            }
            return finalString;
        }
    }
}
