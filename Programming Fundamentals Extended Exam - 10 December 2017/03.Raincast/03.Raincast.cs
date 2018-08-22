using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Raincast
{
    static void Main()
    {
        string type = "";
        string typePattern = @"^Type: (Normal|Warning|Danger)$";
        string source = "";
        string sourcePattern = @"^Source: ([A-Za-z0-9]+)$";
        string forecast = "";
        string forcecastPattern = @"^Forecast:([^!?.,]+)$";
        bool typeReady = false;
        bool sourceReady = false;
        bool forcecastReady = false;
        List<string> result = new List<string>();
        string command = Console.ReadLine();
        while(command!="Davai Emo")
        {
            if (typeReady == false && Regex.IsMatch(command, typePattern))
            {
                Match t = Regex.Match(command, typePattern);
                type = t.Groups[1].Value;
                typeReady = true;
            }

            if(typeReady==true && sourceReady==false && Regex.IsMatch(command, sourcePattern))
            {
                Match s = Regex.Match(command, sourcePattern);
                source = s.Groups[1].Value;
                sourceReady = true;
            }
            if(typeReady==true && sourceReady==true && forcecastReady == false && Regex.IsMatch(command, forcecastPattern))
            {
                Match f = Regex.Match(command, forcecastPattern);
                forecast = f.Groups[1].Value;
                forcecastReady = true;
            }

            if(typeReady==true && sourceReady==true && forcecastReady == true)
            {
                string final = $"({type}){forecast} ~ {source}";
                result.Add(final);
                typeReady = false;
                sourceReady = false;
                forcecastReady = false;
            }
            command = Console.ReadLine();
        }
        foreach (var member in result)
        {
            Console.WriteLine(member);
        }
    }
}