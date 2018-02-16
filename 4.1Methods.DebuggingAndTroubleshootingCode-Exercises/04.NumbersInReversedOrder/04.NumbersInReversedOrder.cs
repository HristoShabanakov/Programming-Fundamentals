using System;
using System.Linq;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseDecimalNumber(input));
        }
        static string ReverseDecimalNumber(string number)
        {
            string reverseNumber = string.Join("", number.Reverse());
            return reverseNumber;
        }
    }
}
