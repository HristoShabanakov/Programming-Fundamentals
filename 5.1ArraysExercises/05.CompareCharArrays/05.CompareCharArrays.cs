using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            char[] arrayOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int shorterArray = Math.Min(arrayOne.Length, arrayTwo.Length);
            //If all letters are equal, the smaller array is the shorter.

            for (int i = 0; i < shorterArray; i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    PrintFirstArray(arrayOne, arrayTwo);
                    return;
                }

                else if(arrayTwo[i] < arrayOne[i])
                {
                    PrintSecondArray(arrayOne, arrayTwo);
                    return;
                }
            }

            if(arrayOne.Length < arrayTwo.Length)
            {
                PrintFirstArray(arrayOne, arrayTwo);
            }
            else
            {
                PrintSecondArray(arrayOne, arrayTwo);
            }
        }

        private static void PrintFirstArray(char[] arrayOne, char[] arrayTwo)
        {
            Console.WriteLine(string.Join("",arrayOne));
            Console.WriteLine(string.Join("",arrayTwo));
        }

        private static void PrintSecondArray(char[] arrayOne, char[] arrayTwo)
        {
            Console.WriteLine(string.Join("", arrayTwo));
            Console.WriteLine(string.Join("", arrayOne));
        }
    }
}
