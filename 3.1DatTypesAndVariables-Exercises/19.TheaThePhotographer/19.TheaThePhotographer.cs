using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main()
        {
            double numberOfPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());
            double percantage = filterFactor / 100.0 ;
            //Finding a percantage of a given number.
            double filteredPictures = Math.Ceiling(percantage * numberOfPictures);
            //Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
            //Initially 500.0 with Math.Ceiling becomes 500.
            double totalTime = numberOfPictures * filterTime;
            double totalUpload = filteredPictures * uploadTime;
            double time = totalTime + totalUpload;
            string timeNeeded = TimeSpan.FromSeconds(time).ToString(@"d\:hh\:mm\:ss");
            // TimeSpan.FromSeconds - get time spans from a specific double unit of time.

            Console.WriteLine(timeNeeded);
        }
    }
}
