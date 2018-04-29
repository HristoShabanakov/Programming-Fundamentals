using System;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main()
        {
           string format = "dd-MM-yyyy";

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[12];

            holidays[0] = new DateTime(4, 01, 01); //New Year Eve(1 Jan)
            holidays[1] = new DateTime(4, 03, 03); //Liberation Day(3 March)
            holidays[2] = new DateTime(4, 05, 01); //Worker’s day(1 May)
            holidays[3] = new DateTime(4, 05, 06); //Saint George’s Day(6 May)
            holidays[4] = new DateTime(4, 05, 24); //Saints Cyril and Methodius Day(24 May)
            holidays[5] = new DateTime(4, 09, 06); //Unification Day(6 Sept)
            holidays[6] = new DateTime(4, 09, 22); //Independence Day(22 Sept)
            holidays[7] = new DateTime(4, 11, 01); //National Awakening Day(1 Nov)
            holidays[9] = new DateTime(4, 12, 24); //Christmas(24,
            holidays[10] = new DateTime(4, 12, 25); //25
            holidays[11] = new DateTime(4, 12, 26); //and 26 Dec)

            int workingDaysCounter = 0;


            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))

            {
                var currentDay = i.DayOfWeek;

                var temporary = new DateTime(4, i.Month, i.Day);

                if (!holidays.Contains(temporary) && (!currentDay.Equals(DayOfWeek.Saturday) && !currentDay.Equals(DayOfWeek.Sunday)))

                {
                    workingDaysCounter++;
                }

            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
