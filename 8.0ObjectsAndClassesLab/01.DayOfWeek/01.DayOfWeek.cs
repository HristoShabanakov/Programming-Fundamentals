using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            //Use the method DateTime.ParseExact(string date, format, provider) to convert the input string to object of type DateTime. 
            //Use format “d-M-yyyy” and CultureInfo.InvariantCulture.
            DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            //The newly created DateTime object has property DayOfWeek.
            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}
