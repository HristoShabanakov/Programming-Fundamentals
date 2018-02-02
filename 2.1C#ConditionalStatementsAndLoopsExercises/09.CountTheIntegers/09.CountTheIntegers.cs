using System;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            try
            {
                while (true)
                {
                    int numbers = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch(Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
