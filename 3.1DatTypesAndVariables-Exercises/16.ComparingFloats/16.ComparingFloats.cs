using System;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double numberOne = Math.Abs(double.Parse(Console.ReadLine()));
            double numberTwo = Math.Abs(double.Parse(Console.ReadLine()));
         //We cannot directly compare two floating-point numbers, because of the nature of floating-point arithmetic.
            double difference = Math.Abs(numberOne - numberTwo);
         //Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps(0.000001).
            double equalWithPrecision = 0.000001;

            if (difference > equalWithPrecision)
            {
                Console.WriteLine("False");
            }

            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
