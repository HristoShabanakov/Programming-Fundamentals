using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal sumNumbers = 0;

            for (int i = 0; i < numbers; i++)
            {
                decimal inputNumbers = decimal.Parse(Console.ReadLine());
                sumNumbers +=inputNumbers;
                //Alternative could be written in one line: sumNumbers += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
