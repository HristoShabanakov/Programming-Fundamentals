using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HornetAssault
{
    static void Main()
    {
        List<int> beehives = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> hornets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < beehives.Count; i++)
        {// Every time when we are removing an element from the list its count is decreasing.
            if (beehives[i] < hornets.Sum())
            {
                beehives.RemoveAt(i);
             // In order to balance it we substract each iteration one element.
                i--;
            }
            else
            {
                beehives[i] -= hornets.Sum();
                if (hornets.Count == 0)
                {
                    Console.WriteLine(string.Join(" ",beehives));
                    return;
                }
                hornets.RemoveAt(0);
            }
        }
        if (beehives.Sum() > 0)
        {
            Console.WriteLine(string.Join(" ", beehives));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}
