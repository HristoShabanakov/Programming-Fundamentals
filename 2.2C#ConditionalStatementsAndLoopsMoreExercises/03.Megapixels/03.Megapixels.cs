using System;

namespace _03.Megapixels
{
    class Program
    {
        static void Main()
        {
            double imageWidth = double.Parse(Console.ReadLine());
            double imageHeight = double.Parse(Console.ReadLine());
            double totalMegapixels = (imageWidth * imageHeight) / 1000000;

            Console.WriteLine($"{imageWidth}x{imageHeight} => {Math.Round(totalMegapixels, 1)}MP");
            //Math.Round. This method rounds numbers to the nearest value. Here we rounded to the first digit after the decimal point.
        }
    }
}
