using System;


namespace _04.PhotoGallery
{
    class Program
    {
        static void Main()
        {

            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine()); // double because the size could be (i.e 1.5, 3.5);
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg"); 
            //with :D(number inside) after the variable we set the number of zeros we want to include.
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");

            if (photoSize < 1000) //The size should be printed in standard human‐readable format(i.e. 950 bytes = 950B.)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize < 1000000) //500000 bytes = 500KB,
            {
                photoSize /= 1000;
                Console.WriteLine(($"Size: {photoSize}KB"));
            }
            else //1500000 bytes = 1.5MB).
            {
                photoSize /= 1000000;
                Console.WriteLine(($"Size: {photoSize}MB"));
            }

            if (photoWidth > photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (landscape)");
            }
            else if (photoHeight > photoWidth)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (portrait)");
            }
            else
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (square)");







        }
    }
}
