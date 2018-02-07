using System;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool result = Convert.ToBoolean(input);
            if (input == "True")
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }
    }
}
