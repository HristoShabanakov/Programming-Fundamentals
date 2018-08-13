using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AnonymousCache
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> dataBase = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
        while (input != "thetinggoesskrra")
        {
            string[] info = input.Split(new char[] { '-', '>', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //With the lenght of the input we know how many words are given to us 1 or 3.
            if (info.Length == 1)
            {
                string set = info[0];
                if (!cache.ContainsKey(set))
                {
                    Dictionary<string, long> current = new Dictionary<string, long>();
                    dataBase.Add(set, current);
                }
                else
                {
                    dataBase.Add(set, cache[set]);
                    cache.Remove(set);
                }
            }
            else
            {
                string key = info[0];
                long size = long.Parse(info[1]);
                string set = info[2];
                if (dataBase.ContainsKey(set))
                {
                    if (!dataBase[set].ContainsKey(key))
                    {
                        dataBase[set].Add(key, size);
                    }

                    else
                    {
                        dataBase[set][key] += size;
                    }
                }
                else
                {
                    if (!cache.ContainsKey(set))
                    {
                        Dictionary<string, long> current = new Dictionary<string, long>();
                        current.Add(key, size);
                        cache.Add(set, current);
                    }
                    else
                    {
                        if (!cache[set].ContainsKey(key))
                        {
                            cache[set].Add(key, size);
                        }
                        else
                        {
                            cache[set][key] += size;
                        }
                    }
                }
            }
            input = Console.ReadLine();
        }
        foreach (var pair in dataBase.OrderByDescending(x => x.Value.Values.Sum()).Take(1))
        {
            Console.WriteLine($"Data Set: {pair.Key}, Total Size: {pair.Value.Values.Sum()}");
            foreach (var item in pair.Value)
            {
                Console.WriteLine($"$.{item.Key}");
            }
        }
    }
}
