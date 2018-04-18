using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class Program
    {
        static void Main()
        {
            var emailList = new Dictionary<string, string>(); // name, email

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                //In a substring, we extract a fragment of an existing string.
                // We can use the Substring method with 2 parameters—the first is 0 and the second is the desired length. 
                string domain = email.Substring(email.Length - 2);
                if(domain =="uk" || domain == "us")
                {
                    continue;
                }
                else
                {
                    emailList.Add(name, email);
                }
            }

            foreach (var item in emailList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
