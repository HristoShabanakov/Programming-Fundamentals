using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main()
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            int capacityOfPersons = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double) numberOfPersons / capacityOfPersons);
         //Math Ceiling always returns double so we have to cast it to int, because we want to print the result in integers.
            Console.WriteLine(courses);
        }
    }
}
