using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
         //Casting years to int because we multiply with floating point number.
            int days = (int) (years * 365.2422);
         //A tropical year, also known as a solar year, an astronomical year, or an equinoctial year, is, on average, approximately 365 days, 5 hours, 48 minutes and 45 seconds long (365.24219 days).
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
