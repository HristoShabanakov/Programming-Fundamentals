using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombsArgs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int index = numbers.IndexOf(bombsArgs[0]);

            //
            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] == bombsArgs[0])
                {//The loop starts from j "bomb index" - "power of the bomb"
                 //continues until "power of the bomb" + index
                    for (int j = i - bombsArgs[1]; j <= bombsArgs[1] + i; j++)
                    {
                        //To check that we are not out of the list length.
                        if (j >= 0 && j <= numbers.Count - 1)
                        {
                            numbers[j] = 0;
                            //We dont manipulate the list through the loops.
                        }
                    }

                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}