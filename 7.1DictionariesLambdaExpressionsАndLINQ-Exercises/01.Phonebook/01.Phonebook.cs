using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (!input.Equals("END"))
            {
                string[] phonebookEntry = Console.ReadLine().Split(' ').ToArray();

                if (phonebookEntry[0].Equals("A"))
                {
                    string name = phonebookEntry[1];
                    string number = phonebookEntry[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, string.Empty);
                    }
                    phonebook[name] = number;
                }

                else
                {
                    string name = phonebookEntry[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                
            }
            input = Console.ReadLine();
        }
    }
}
