using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SnowMen
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (input.Count != 1)
        {
            
            for (int i = 0; i < input.Count; i++)
            {
                //Each element of input is an attacker index
                int attackerIndex = i;
                if (input[i].Equals(-1))
                {
                    continue;
                }
                //and its integer value is its target index.
                int targetIndex = input[attackerIndex] % input.Count;
                //If the integer value is greater than the length of the sequence, divide it modulo (%) by the length of the sequence.

                int looserIndex = -1;

                if (attackerIndex == targetIndex)
                {
                    looserIndex = attackerIndex;
                    Console.WriteLine($"{attackerIndex} performed harakiri");
                }
                else
                {
                    int difference = Math.Abs(attackerIndex - targetIndex);
                    int winnerIndex = -1;

                    //If the difference is an even number, the attacker wins
                    if (difference % 2 == 0)
                    {
                        winnerIndex = attackerIndex;
                        looserIndex = targetIndex;
                    }
                    else
                    {
                        winnerIndex = targetIndex;
                        looserIndex = attackerIndex;
                    }
                    Console.WriteLine($"{attackerIndex} x {targetIndex} -> {winnerIndex} wins");
                }

                if (!input[looserIndex].Equals(-1))
                {
                    input[looserIndex] = -1;
                }

                if (input.Count == input.Where(e => e.Equals(-1)).Count() + 1)
                {
                    break;
                }

                input = input.Where(e => !e.Equals(-1)).ToList();
            }
        }
    }
}

