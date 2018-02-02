using System;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main()
        {
            string months = Console.ReadLine();
            double nightsCounts = double.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doubleRoomPrice = 0;
            double suitePrice = 0;

            if (months == "May" || months == "October")
            {
                studioPrice = 50;
                doubleRoomPrice = 65;
                suitePrice = 75 ;

                if (nightsCounts > 7)
                {
                    studioPrice = (studioPrice - (studioPrice * 0.05));
                }
            }
            else if (months == "June" || months == "September")
            {
                studioPrice = 60 ;
                doubleRoomPrice = 72 ;
                suitePrice = 82  ;

                if (nightsCounts > 14)
                {
                    doubleRoomPrice = doubleRoomPrice - (doubleRoomPrice * 0.1);
                }
                
            }

            else if (months == "July" || months == "August" || months == "December")
            {
                studioPrice = 68 ;
                doubleRoomPrice = 77 ;
                suitePrice = 89 ;

                if (nightsCounts > 14)
                {
                    suitePrice = suitePrice - (suitePrice * 0.15);
                }
            }

            var totalStudioPrice = studioPrice * nightsCounts;
            var totalDoubleRoomPrice = doubleRoomPrice * nightsCounts;
            var totalSuitePrice = suitePrice * nightsCounts; 

            if ((months == "September" || months == "October") && nightsCounts > 7)
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoubleRoomPrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");
        }
    }
}
