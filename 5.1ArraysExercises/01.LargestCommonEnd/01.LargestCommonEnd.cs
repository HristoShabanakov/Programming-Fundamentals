using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWordsA = Console.ReadLine().Split(' ').ToArray();
            string[] arrayOfWordsB = Console.ReadLine().Split(' ').ToArray();

            double shorterArray = Math.Min(arrayOfWordsA.Length, arrayOfWordsB.Length);
            //Math Min - returns the smaller of the arguments.

            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < shorterArray; i++)
             //We use the shorterarray, because if we use some of the input arrays we might get OutOfRangeException.
            {
                if (arrayOfWordsA[i] == arrayOfWordsB[i])
                {
                    leftCount++;
                }
                if (arrayOfWordsA[arrayOfWordsA.Length-i-1] == arrayOfWordsB[arrayOfWordsB.Length-i-1])
                    //"arraysOfWordsA.Length - i - 1" - takes the last element of the array 
                    //"i" - is taking the next last element with each loop
                {
                    rightCount++;
                }
            }

            Console.WriteLine(Math.Max(leftCount,rightCount));
            //Math Max - returns the larger of the two arguments.
        }
    }
}
