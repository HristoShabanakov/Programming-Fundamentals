using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] parameters = input.Split('|');
                string city = parameters[0];
                string country = parameters[1];
                long population = long.Parse(parameters[2]);
                //If does not contain
                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>()); //new initialization of the dictionary (object).
                    countries[country].Add(city, population);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var country in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
