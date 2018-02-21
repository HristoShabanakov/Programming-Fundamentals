using System;

namespace DistanceBetweenTwoMonths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First month (1-12): ");
            int firstMonth = int.Parse(Console.ReadLine());

            Console.Write("Second month (1-12): ");
            int secondMonth = int.Parse(Console.ReadLine());

            SpecifyPeriod(firstMonth, secondMonth);
        }
        
        static string GetMonth(int month)
        {
            string monthName;
            switch (month)
            {
                case 1:
                    monthName = "January";
                        break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    Console.WriteLine("Invalid month!");
                    return null;
            }
            return monthName;
        }

        static void SpecifyPeriod (int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;

            if(period < 0)
            //If the difference between "startMonth" and "endMonth"  is negative , 
            //it means that the user has entered a number(month) which is located within the next calendar year.
            {
                period = period + 12;
                //Adding 12 in order to find the length of the current period.
            }

            Console.WriteLine($"There is a {period} months period from {GetMonth(startMonth)} to {GetMonth(endMonth)}.");
        }
    }
}
