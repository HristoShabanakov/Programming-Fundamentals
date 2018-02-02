using System;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOne:D4} {numberTwo:D4} {numberThree:0000} {numberFour:0000}");
        }
    }
}
