using System;

namespace _01.PadawanEquipment
{
    class Program
    {
        static void Main()
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal sabresPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            int sabersCount = Convert.ToInt32(Math.Ceiling(students + (students * 0.1)));
            int robesCount = students;
            int beltsCount = students - students / 6;
            decimal total = sabersCount * sabresPrice + robesCount * robesPrice + beltsCount * beltsPrice;

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
