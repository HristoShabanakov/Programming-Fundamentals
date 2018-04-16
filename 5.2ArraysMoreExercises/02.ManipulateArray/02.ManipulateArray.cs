using System;
using System.Linq;

namespace _02.ManipulateArray
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "Reverse":
                        words = words.Reverse().ToArray();
                        break;

                    case "Distinct":
                       words = words.Distinct().ToArray();
                        break;

                    case "Replace":
                        var index = int.Parse(input[1]);
                        var word = input[2];
                        words[i] = word;
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", words));

        }
    }
}
