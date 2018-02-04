using System;

namespace _06.DNASequences
{
    class Program
    {
        static void Main()
        {

            int sumOfElements = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        string nucleidAcidSequence = i + j + k >= sumOfElements ? "O" : "X";
                     //The conditional operator (?:) returns one of two values depending on the value of a Boolean expression.
                     //If sumOfElements is "greater than or equal" >= nucleidAcidSequence print the sequence with an “O” before and after it, otherwise print “X” before and after it.
                        Console.Write($"{nucleidAcidSequence}{i}{j}{k}{nucleidAcidSequence} "
                     //String.Replace returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
                            .Replace("1","A")
                            .Replace("2","C")
                            .Replace("3","G")
                            .Replace("4","T"));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
