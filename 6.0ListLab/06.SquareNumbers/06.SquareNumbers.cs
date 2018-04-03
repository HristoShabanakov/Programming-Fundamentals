using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> squareNumbers = new List<int>();

            foreach (var number in numbers)
            {

                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                //To find out whether an integer is “square number”, check whether its square root is integer number.
                {
                    squareNumbers.Add(number);
                }
                squareNumbers.Sort((a, b) => b.CompareTo(a));
                //order the results list in descending order use sorting by lambda function:
            }

            //Print the result.
            Console.WriteLine(String.Join(" ",squareNumbers));
        }
    }
}
