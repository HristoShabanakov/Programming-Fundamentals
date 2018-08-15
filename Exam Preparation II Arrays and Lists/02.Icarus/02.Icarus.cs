using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Icarus
{
    static void Main()
    {
        int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int damage = 1;
        int position = int.Parse(Console.ReadLine());
        string[] command = Console.ReadLine().Split(' ').ToArray();

        while (command[0] != "Supernova")
        {
            int steps = int.Parse(command[1]);
            if (command[0] == "left")
            {
                for (int i = 0; i < steps; i++)
                {
                    //If Icarus passes beyond the start of the sequence (index: -1) while going left,
                    //he must go at the end of the sequence (index: length – 1).
                    if (position == 0)
                    {
                        position = sequence.Length - 1;
                        //If 1 of the 2 cases stated above happens, Icarus increments his damage by 1.
                        damage++;
                    }
                    else
                    {
                        //If the position is different than zero just move one position backwards
                        position--;
                    }
                    //Each time he steps on a NEW position, he damages it.
                    sequence[position] -= damage;
                }
            }
            else if (command[0] == "right")
            {
                for (int i = 0; i < steps; i++)
                {
                    //If Icarus passes beyond the end of the sequence (index: length - 1) while going right,
                    //he must go at the start of the sequence (index: 0).
                    if (position == sequence.Length - 1)
                    {
                        position = 0;
                        //If 1 of the 2 cases stated above happens, Icarus increments his damage by 1.
                        damage++;
                    }
                    else
                    {
                        position++;
                    }
                    //Each time he steps on a NEW position, he damages it.
                    sequence[position] -= damage;
                }
            }
            command = Console.ReadLine().Split(' ').ToArray();
        }
        Console.WriteLine(string.Join(" ",sequence));
    }
}

