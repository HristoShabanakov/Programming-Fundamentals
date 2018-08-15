using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PokemonDontGo
{
    static void Main()
    {
        List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int sum = 0;
        int index = 0;
        int current = 0;

        while(sequence.Count > 0)
        {
            index = int.Parse(Console.ReadLine());
            if (index < 0)
            {
                current = sequence[0];
                sequence.RemoveAt(0);
                sequence.Insert(0, sequence[sequence.Count - 1]);
            }
            else if (index >= sequence.Count)
            {
                current = sequence[sequence.Count - 1];
                sequence.RemoveAt(sequence.Count - 1);
                sequence.Add(sequence[0]);
            }
            else
            {
                current = sequence[index];
                sequence.RemoveAt(index);
            }

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] <= current)
                {
                    sequence[i] += current;
                }
                else
                {
                    sequence[i] -= current;
                }
            }
            sum += current;
        }
        Console.WriteLine(sum);
    }
}
