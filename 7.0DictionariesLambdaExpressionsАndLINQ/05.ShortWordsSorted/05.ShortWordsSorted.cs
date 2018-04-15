using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main()
        {

            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(", ; : . ! ( ) \" ' \\ / [ ] "
                .ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            words = words.Where(s => s.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", " ,words));
        }
    }
}
