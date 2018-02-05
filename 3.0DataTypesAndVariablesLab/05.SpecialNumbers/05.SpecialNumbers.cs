using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            
            for (int number = 1; number <=input; number++)
            {
                int sumOfDigits = 0;
                int digits = number;
             //Declaring the variable "digits" which will store the value from "1" to entered "input" within the "for loop" above. 
                while (digits > 0)
             // this loop will perform until "the given number" reaches 0.
                {
                    sumOfDigits += digits % 10;
             //To calculate sum of digits of given number: sum the last digit "digits % 10" and remove it
                    digits = digits / 10;
             //"digits / 10" until the given number reaches 0.
                }
                bool magicNumber = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{number} -> {magicNumber}");
                
            }
        }
    }
}
