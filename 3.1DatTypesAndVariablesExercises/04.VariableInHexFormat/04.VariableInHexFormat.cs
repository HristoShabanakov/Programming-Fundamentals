using System;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine(); //reading a number in  "hexadecimal format (0x##)"
            int result = Convert.ToInt32(input,16); // using Convert.ToInt32 - converting it to decimal format.
            Console.WriteLine(result);
        }
    }
}
