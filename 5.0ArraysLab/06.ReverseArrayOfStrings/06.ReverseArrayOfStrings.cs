using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main()
        {

            string[] array = Console.ReadLine().Split(' ').ToArray();

            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
