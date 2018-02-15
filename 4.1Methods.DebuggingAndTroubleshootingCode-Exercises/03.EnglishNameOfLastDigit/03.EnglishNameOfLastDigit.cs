using System;

namespace _03.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main()
        {
            PrintEnglishName();
        }
        static void PrintEnglishName()
        {
            long input = Math.Abs( long.Parse(Console.ReadLine()));
            long lastDigit = input % 10;
            switch (lastDigit)
            //We can replace the "switch" construction with an "array" of strings.
            //string[] digitAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                        break;
                case 5:
                    Console.WriteLine("five");
                        break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;
            }

        }
    }
}
