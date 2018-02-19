using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int trailingZeros = GetTrailingZeros(number);

            Console.WriteLine(trailingZeros);

        }


        public static int GetTrailingZeros(int number)
        {

            int count = 0;
            for (int i = 5; number / i >= 1; i *= 5)
            {
                count += number / i;
            }
            return count;
        }
    }
}
