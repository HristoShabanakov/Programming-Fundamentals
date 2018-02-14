using System;
using System.Globalization;

namespace _10.HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), 
            "d.M.yyyy", CultureInfo.InvariantCulture);
        //Broken code was : "dd.m.yyyy"
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
        //Broken code was : "dd.m.yyyy"
            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
          //Broken code : "date =" - was missing.

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    holidaysCount++;
         //Broken code  : "||" was replaced by "&&"
            Console.WriteLine(holidaysCount);
        }
    }
}
