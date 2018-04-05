using System;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main()
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());
            double bars = numberOfBeats / 4;
            double seconds = numberOfBeats * 60 / beatsPerMinute;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {Math.Floor(seconds)}s ");
            

        }
    }
}
