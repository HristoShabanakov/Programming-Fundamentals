using System;
using System.Linq;


class Rainer
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //In this array we have all elements except the last one.
        int[] field = new int[input.Length - 1];
        //Another array to compare 
        int[] initial = new int[input.Length - 1];
        int rounds = 0;

        for (int i = 0; i < input.Length - 1; i++)
        {
            field[i] = input[i];
            initial[i] = input[i];
        }
        //Here is the last element.
        int index = input[input.Length - 1];

        while (true)
        {//you must decrease all of the integers in the sequence’ values by 1
            for (int i = 0; i < field.Length; i++)
            {
                field[i]--;

            }
            //If an integer reaches 0, that means a raindrop has fallen there
            if (field[index] == 0)
            {
                break;
            }
            //If an integer reaches 0, and Donald is not there, 
            //you must return the integer to its original value. (initial value)
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] == 0)
                {
                    field[i] = initial[i];
                }
            }
            rounds++;
            index = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(string.Join(" ", field));
        Console.WriteLine(rounds);
    }
}
