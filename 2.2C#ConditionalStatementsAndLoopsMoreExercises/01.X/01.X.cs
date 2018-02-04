using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)// with this for loop we are printing the upper part of the figure.
            {
                var side = new string(' ', i);
                var middle = new string(' ', n - (i * 2 + 2));
                Console.WriteLine($"{side}x{middle}x{side}");
            }

            var center = new string(' ', n / 2);

            Console.WriteLine($"{center}x{center}");

            for (int i = n/2; i > 0; i--) // printing the lower part of the figure
            {
                var side = new string(' ', i - 1);
                var middle = new string(' ', n -2 * i);
                Console.WriteLine($"{side}x{middle}x{side}");
            }
        }
    }
}
