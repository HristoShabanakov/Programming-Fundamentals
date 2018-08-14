using System;

class SoftUniReception
{
    static void Main()
    {
        int employeeOne = int.Parse(Console.ReadLine());
        int employeeTwo = int.Parse(Console.ReadLine());
        int employeeThree = int.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        int hours = 0;
        int studentsServed = 0;

        int studentsPerHour = employeeOne + employeeTwo + employeeThree;

        while (studentsServed <studentsCount)
        {
            studentsServed += studentsPerHour;
            hours++;
        //Every forth hour all of the employees have a break, so they don’t work for a hour.
            if (hours % 4 == 0)
                hours++;
        }

        Console.WriteLine($"Time needed: {hours}h.");
    }
}

