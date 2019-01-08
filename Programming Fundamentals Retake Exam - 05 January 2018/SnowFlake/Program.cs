using System;
using System.Text.RegularExpressions;

namespace SnowFlake
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = string.Empty;
            for (int i = 1; i <= 5; i++)
            {
                lines += Console.ReadLine() + "\n";
            }
            string pattern = "^([^A-Za-z0-9]+)\n([0-9_]+)\n([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)\n([0-9_]+)\n([^A-Za-z0-9]+)\n$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(lines))
            {
                int coreLength = regex.Match(lines).Groups["core"].Value.Length;
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
