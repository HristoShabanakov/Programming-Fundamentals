using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {

                if ("aoueiy".IndexOf(input) >= 0) Console.WriteLine("vowel");
                else Console.WriteLine("other");
            }
        }
    }
}
