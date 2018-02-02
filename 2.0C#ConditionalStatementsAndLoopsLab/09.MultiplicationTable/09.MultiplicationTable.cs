using System;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int times = 1;

            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }
        }
    }
}
