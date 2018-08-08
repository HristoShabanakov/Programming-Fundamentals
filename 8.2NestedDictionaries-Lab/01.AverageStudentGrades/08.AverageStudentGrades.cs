using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class AverageStudentGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string[] info = Console.ReadLine().Split(' ').ToArray();
            string name = info[0];
            double grade = double.Parse(info[1]);
            //Ако речникът не съдържа името на студента го добавяме към речника.
            if (!students.ContainsKey(name))
            {
                List<double> grades = new List<double>(); // инициализираме листа от речника
                grades.Add(grade); // и добавяме оценките в него
                students.Add(name, grades);// пълним речника със имената на учениците и техните оценки
            }
            else
            {
                //Ако студентът съществува добавяме към него оценката му.
                //Чрез този запис влизаме в дадено име на студент,
                //после отиваме във value на листа и добавяме оценката.
                students[name].Add(grade);
            }
        }

        foreach (var pair in students)
        {
            var name = pair.Key;
            var studentsGrades = pair.Value;
            var average = pair.Value.Average();

            Console.Write($"{name}->");
            foreach (var grade in studentsGrades)
            {
                Console.Write($"{grade:f2}");

                Console.WriteLine($"(avg:{average:f2})");
            }
        }
    }
}

