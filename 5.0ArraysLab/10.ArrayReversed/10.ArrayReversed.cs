using System;
using System.Linq;

namespace _10.ArrayReversed
{
    class Program
    {
        static void Main()
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //We create an array from ints and initialize it with the values in "{ }".
            int length = array.Length;
            //We save the Length of the array in new variable "int length"
            int[] reversed = new int[length];
            //We declared a new array [] reversed, where we save the elements of the original [] array;

            for (int i = 0; i < length; i++)
            {
                reversed[length - i - 1] = array[i];
            }

            //for (int i = 0; i < length; i++)
            //{
            //Console.WriteLine(reversed[i] + " ");
            //}

            Console.WriteLine(String.Join("\r\n", reversed)); //easy way to print an array
        }
    }
}
