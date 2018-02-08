using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            
            string result = Convert.ToString(input,16).ToUpper();
            string binary = Convert.ToString(input, 2).ToUpper();
            Console.WriteLine(result);
            Console.WriteLine(binary);
        }
    }
}
