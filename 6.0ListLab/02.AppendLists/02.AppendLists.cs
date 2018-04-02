using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string [] arrayOfTokens = Console.ReadLine() // Split the input by ‘|’ into array of tokens.
                .Split('|');

            List<int> result = new List<int>(); //Create a new empty list for the results.

            for (int i = arrayOfTokens.Length - 1; i >= 0 ; i--)
            //Order the lists from the last to the first, and their values from left to right.
            {
                int[] elements = arrayOfTokens[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                //Pass through each of the obtained tokens from right to left. 
                //For each token, split it by space and append all non‐empty tokens to the results.


                result.AddRange(elements); //Save the elements in new List.

            }

            Console.WriteLine(String.Join(" ",result)); //Print the results.
        }
    }
}
