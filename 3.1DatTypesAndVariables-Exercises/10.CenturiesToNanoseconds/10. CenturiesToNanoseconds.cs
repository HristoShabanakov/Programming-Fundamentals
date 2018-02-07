using System;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());

            int years = centuries * 100;
            ulong days = (ulong) (years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000m;
            decimal nanoseconds = microseconds * 1000m;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds ");
        }
    }
}

