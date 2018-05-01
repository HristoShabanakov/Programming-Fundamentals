using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] input = Console.ReadLine().Split();
                student.Name = input[0];
                //We skip one element(the name) then parse the number from the console.
                student.Grades = input.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }

            //Read a list of students and print the students that have average grade ≥ 5.00
            students
                .Where(s => s.Average >= 5.00)
                //ordered  them by name (ascending)
                .OrderBy(s => s.Name)
                //then by average grade (descending). We use ThenByDescending, 
                //because OrderByDescending will overwrite the list.
                .ThenByDescending(s => s.Average)
                .ToList()
                //We can use List method ForEach to print the list .
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.Average:f2}"));
        }
    }
}
class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double Average => Grades.Average(); // Calculated by LINQ as Grades.Average(), read‐only.
}
