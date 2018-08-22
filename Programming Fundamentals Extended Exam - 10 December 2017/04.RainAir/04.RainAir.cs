using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RainAir
{
    static void Main()
    {
        Dictionary<string, List<int>> customers = new Dictionary<string, List<int>>();
        string input = Console.ReadLine();

        while (input != "I believe I can fly")
        {
            string[] command = input.Split(' ').ToArray();

            if (command[1] != "=")
            {
                string customer = command[0];
                List<int> flights = new List<int>();
                for (int i = 1; i <= command.Length-1; i++)
                {
                    flights.Add(int.Parse(command[i]));
                }

                if (!customers.ContainsKey(customer))
                {
                    customers.Add(customer, flights);
                }
                else
                {
                    customers[customer].AddRange(flights);
                }
            }
            else
            {
                string customerOne = command[0];
                string customerTwo = command[2];
                customers[customerOne] = customers[customerTwo].ToList();
            }
            input = Console.ReadLine();
        }
        foreach (var pair in customers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"#{pair.Key} ::: {string.Join(", ",pair.Value.OrderBy(x => x))}");
        }
    }
}

