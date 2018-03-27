using System;
using System.Linq;

namespace _3._1FoldAndSum
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] leftSum = new int [inputArray.Length / 4];
         //In order to separate the array in 3 parts we have to divide his length by 4.
            int[] rightSum = new int[inputArray.Length / 4];
         //Each part of the array we stored in  a new array.
            int[] result = new int[inputArray.Length / 2];
         //In this array we keep the middle part of the "inputArray".

            for (int i = 0; i < (inputArray.Length / 4); i++)
         //If the input array has 8 elements with the "for loop" we are folding the elements on 1st/2nd positions,
         //and the last two elements which are on 7th/8th positions.
            {
                leftSum[i] = inputArray[(inputArray.Length / 4) - i - 1]; //Reversing the first two elements.
                rightSum[i] = inputArray[inputArray.Length - i - 1]; //Reversing the last two elements.
            }

            for (int i = 0; i < (inputArray.Length / 4); i++)
            //In this "loop" we sum the reversed left "lestSum" part and the reversed right "rightSum" part of "inputArray",
            //with the middle part of "inputArray", which stays untouched.
            {
                result[i] = leftSum[i] + inputArray[inputArray.Length / 4 + i];
                result[inputArray.Length / 4 + i] = rightSum[i] + inputArray[inputArray.Length / 2 + i];
            }

            Console.WriteLine(string.Join(" ",result));
            //Prints the total result of both rows by index.
        }
    }
}
