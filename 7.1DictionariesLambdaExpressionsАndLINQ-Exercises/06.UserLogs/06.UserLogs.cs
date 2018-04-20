using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var users =new Dictionary<string, Dictionary<string,int>>(); // user - ip - count

            while (true)
            {
                String line = Console.ReadLine();
                if(line == "end")
                {
                    break;
                }

                string[] commands = line.Split(' ');

                string name = commands[2].Replace("user", "");
                string ip = commands[0].Replace("IP=", "");

                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }

                if (!users.ContainsKey(ip))
                {
                    users[name].Add(ip, 0); // we set the count to zero
                }
                users[name][ip] = users[name][ip] + 1;
            }

            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key + ": " );

                StringBuilder sb = new StringBuilder();
                //In order to access the second dictionary we are making another foreach loop
                foreach (var ipAndCount in user.Value)
                {
                    sb.Append(ipAndCount.Key).Append(" => ").Append(ipAndCount.Value + ", ");
                }

                sb.Remove(sb.Length - 2,2);
                sb.Append(".");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
