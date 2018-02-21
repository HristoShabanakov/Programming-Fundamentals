using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //Read a number from the console
            int[] array = new int[n]; //Create an array with length equal to n.
            
            for (int i = 0; i < n; i++) 
            {
                array[i] = int.Parse(Console.ReadLine()); //storing the input numbers from the console in this array
            }

            for (int i = n-1; i >= 0; i--) //reverse loop to pass the elements from the array in reverse order
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
