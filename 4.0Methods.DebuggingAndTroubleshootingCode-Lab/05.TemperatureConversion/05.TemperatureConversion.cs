using System;

namespace _05.TemperatureConversion
{
    class Program
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit); //Invoking the method and saving its return value in new variable.
            Console.WriteLine($"{celsius:f2}");
        }

        static double FahrenheitToCelsius(double fahrenheit) //Creating method which returns a value of type double.
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
