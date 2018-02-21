using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation
{
    class DataValidation
    {
        static void Main()
        {
            Console.WriteLine("What time is it?");

            Console.Write("Hours ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Minutes ");
            int minutes = int.Parse(Console.ReadLine());

            bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);

            if (isValidTime)
            {
                Console.WriteLine($"The time is {hours}:{minutes} now.");
            }
            else
            {
                Console.WriteLine("Incorrect time!");
            }
        }

        static bool ValidateHours(int hours)
        {
            bool result = (hours >= 0) && (hours < 24);
            return result;
        }

        static bool ValidateMinutes(int minutes)
        {
            bool result = (minutes >= 0) && (minutes < 59);
            return result;
        }
    }
}
