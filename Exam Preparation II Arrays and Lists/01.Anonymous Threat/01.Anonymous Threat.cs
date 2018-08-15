using System;
using System.Collections.Generic;
using System.Linq;


class AnonymousThreat
{
    static void Main()
    {//You will receive a single input line containing STRINGS separated by spaces.
        List<string> words = Console.ReadLine().Split(' ').ToList();
        //You will then begin receiving commands in one of the following formats:
        //merge {startIndex} {endIndex}
        //divide {index} {partitions}.
        string[] command = Console.ReadLine().Split(' ').ToArray();

        while (command[0] != "3:1")
        {

            if (command[0] == "merge")
            {
                int start = int.Parse(command[1]);
                int end = int.Parse(command[2]);
    //If any of the given indexes is out of the array, you must take ONLY the range that is INSIDE the array and merge it.
                if (start < 0)
             //If start is -1 is out of the array change it to the first position of the array.
                {
                    start = 0;
                }
             //If end is bigger or equals to array's lenght, change it to the last index of the array.
                if (end >= words.Count)
                {
                    end = words.Count - 1;
                }
                for (int i = start; i < end; i++)
                {
                //Merging the first position of the list with the next one
                    words[start] = words[start] + words[start + 1];
                //We have to delete the next position, the one we merged with the index.
                //like this the lenght of the list is decreasing.
                    words.RemoveAt(start + 1);
                }
            }
            else if (command[0] == "divide")
            {
                int index = int.Parse(command[1]);
                int partitions = int.Parse(command[2]);
                //If we have at position Index the word Tony - the length of the word will be 4.
                int numberOfLetters = words[index].Length / partitions;
                string current = words[index];
                List<string> divided = new List<string>();
                for (int i = 0; i < partitions; i++)
                {
                    divided.Add(current.Substring(0, numberOfLetters));
                    current = current.Remove(0, numberOfLetters);
                }
                divided[divided.Count - 1] = divided[divided.Count - 1] + current;
                words.RemoveAt(index);
                words.InsertRange(index, divided);
            }

            command = Console.ReadLine().Split(' ').ToArray();
        }
        Console.WriteLine(string.Join(" ",words));
    }
}
