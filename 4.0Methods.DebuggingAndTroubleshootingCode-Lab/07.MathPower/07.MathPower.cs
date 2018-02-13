using System;

namespace _07.MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        static double RaiseToPower (double number, int power)
        {
            return Math.Pow(number, power);
            //Math.Pow - computes exponential values. It takes the powers of numbers such as by squaring values.
            //The parameters must be doubles or types that are convertible to double types.
            //The first parameter indicates the number you are trying to base the result on. The second parameter is the exponent itself.
        }
    }
}
