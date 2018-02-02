using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            var combinationsCounter = 0;
            var result = 0.0;

            for (int i = n; i >= 1; i--) //with the first loop we are decreasing from N to 1
            {
                for (int j = 1; j <= m; j++) //with the second loop we are increasing from 1 to M
                {

                    if (result >= boundary)
                    {
                        break;
                    }
                    result += (i * j) * 3; // Multipliying the two digits, and their product by 3. Add the result to the total sum.
                    combinationsCounter++;

                }
            }
            if (result >= boundary)
            {
                Console.WriteLine($"{combinationsCounter} combinations");
                Console.WriteLine($"Sum: {result} >= {boundary}");

            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations");
                Console.WriteLine($"Sum: {result}");
            }

        }
    }
}
