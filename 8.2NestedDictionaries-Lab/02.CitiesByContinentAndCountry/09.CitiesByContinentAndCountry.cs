using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CitiesByContinentAndCountry
{
    static void Main()
    {
        var info = new Dictionary<string, Dictionary<string, List< string>>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string continent = input[0];
            string country = input[1];
            string city = input[2];

            if (!info.ContainsKey(continent))
            {
                Dictionary<string,List< string>> current = new Dictionary<string, List<string>>();
                current.Add(country, new List<string> { city });
                //Add, очаква да му въведем две стойности (key & value) в случая string и после dictionary.
                info.Add(continent, current);
            }
            else
            {//Info [continent] is Dictionary from string and string
                if (!info[continent].ContainsKey(country))
                {
                    info[continent].Add(country, new List<string> { city });
                }
                //Info[continent][country] is value of value of second Dictionary
                else
                {
                    info[continent][country].Add(city);
                }
            }
        }

        foreach (var pair in info)
        {
            Console.WriteLine($"{pair.Key}");

            foreach (var country in pair.Value)
            {
                Console.WriteLine($"{country.Key} -> {string.Join(",  ",country.Value)}");
            }
        }
        
    }
}
