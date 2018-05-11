using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PadawanEquipment
{
    class Program
    {
        static void Main()
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            long students = long.Parse(Console.ReadLine());
            decimal sabresPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

           

            int totalStudents = Convert.ToInt32(Math.Ceiling(students + (students * 0.1)));
            decimal sabresSum = sabresPrice * (totalStudents);
            decimal robesSum = robesPrice * students;
            decimal beltsFree = (beltsPrice * students) / 6 / beltsPrice;
            decimal beltsSum = beltsPrice * (students - Math.Round(beltsFree));
            decimal total = (decimal) sabresSum + robesSum + beltsSum;
            if (total <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - amountOfMoney:f2}lv more.");
            }
        }
    }
}
