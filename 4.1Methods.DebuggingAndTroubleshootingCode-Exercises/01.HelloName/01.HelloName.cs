using System;

namespace _01.HelloName
{
    class Program
    {
        static void Main()
        {
            PrintName();
        }

        static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
