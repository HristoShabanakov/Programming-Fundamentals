using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, string>(); //name phone number

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var commands = line.Split(' ');
                if (commands[0] == "A")
                {
                    //In commands[1] we save the name of the person, in commands[2] we save his number.
                    phonebook[commands[1]] = commands[2]; 
                    //If contact name already exist the program will replace the old number with the new one.
                }

                else if (commands[0] == "S")
                {
                    //if the name does not exist
                    if (!phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }

                    else
                    {
                        //we pass through all of the records in our phonebook 
                        //and check if the current record is equal to the name saved in "commands[1]"
                        foreach (var item in phonebook)
                        {
                            //we print the name and the number
                            if(item.Key == commands[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                    }
                }

                else if (commands[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}
