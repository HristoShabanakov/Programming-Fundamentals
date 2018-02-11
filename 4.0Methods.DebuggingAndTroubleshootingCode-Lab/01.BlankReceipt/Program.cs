using System;

namespace _012.BlankReceipt
{
    class Program
    {
        static void Main()
        {
            PrinteReceipt();
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintMiddle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void PrinteReceipt()
        {
            PrintHeader();
            PrintMiddle();
            PrintFooter();
        }
    }
}
