using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSums
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];
            sequence[0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = i-1; j >=Math.Max(0, i-k); j--)
                {
                    sequence[i] += sequence[j];
                }
            }

            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
