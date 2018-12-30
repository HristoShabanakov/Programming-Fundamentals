using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {
        List<string> chatList = new List<string>();
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            List<string> commands = input.Split(' ').ToList();
            string command = commands[0];
            string message = commands[1];

            switch (command)
            {
                case "Chat":
                    //add the message at last position in the chat.
                    chatList.Add(message);
                    break;

                case "Delete":
                    //delete the message if it exists.
                    if (chatList.Contains(message))
                    {
                        chatList.Remove(message);
                    }
                    break;

                case "Edit":
                    string editedVersion = commands[2];
                    //update the message with the edited version.
                    for (int i = 0; i < chatList.Count; i++)
                    {
                        if (chatList[i].Contains(message))
                            chatList[i] = editedVersion;
                    }

                    break;
               
                case "Pin":
                    //find the given message and move it to the last index
                    var value = chatList.Find(x => x == message);
                    chatList.Remove(message);
                    var endIndex = chatList.Count;
                    chatList.Insert(endIndex, value);

                    break;

                case "Spam":
                    //add all messages at the end of the chat.
                    commands.Remove("Spam");
                    chatList.AddRange(commands);

                    break;
            }
        }
        Console.WriteLine(string.Join("\n", chatList));
    }
}

