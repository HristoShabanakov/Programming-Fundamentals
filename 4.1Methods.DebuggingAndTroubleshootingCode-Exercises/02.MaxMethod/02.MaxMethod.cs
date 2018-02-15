using System;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main()
        {
            
            GetMaxOfTwoNumbers();
        }

         static void GetMaxOfTwoNumbers ()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(numberOne, Math.Max(numberTwo,numberThree));

            Console.WriteLine(maxNumber);
        }
    }
}
