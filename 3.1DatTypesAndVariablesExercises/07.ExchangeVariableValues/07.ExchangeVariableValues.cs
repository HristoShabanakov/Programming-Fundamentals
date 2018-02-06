using System;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temporaryValue = 0;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Console.WriteLine("After:"); 
            Console.WriteLine($"a = {temporaryValue = b}");
            Console.WriteLine($"b = {temporaryValue = a}");

        }
    }
}
