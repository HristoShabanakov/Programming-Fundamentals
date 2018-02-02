using System;

namespace _05.ForeignLanguages
{
    class Program
    {
        static void Main()
        {
            var country = Console.ReadLine();
            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English"); break;

                case "Spain":
                case "Mexico":
                case "Argentina":
                    Console.WriteLine("Spanish"); break;
                default:
                    Console.WriteLine("unknown"); break;
            }
        }
    }
}
