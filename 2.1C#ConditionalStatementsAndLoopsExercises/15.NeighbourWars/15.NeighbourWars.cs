using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main()
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            int round = 0;

            while (peshosHealth > 0 && goshosHealth > 0)
            {
                round++;
                if(round % 2 != 0)
                {
                    goshosHealth -= peshosDamage;
                    if(goshosHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                if(round % 3 == 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }
        }
    }
}
