using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> videos = new Dictionary<string, int>();
        Dictionary<string, int> likes = new Dictionary<string, int>();
        string input;

        while ((input = Console.ReadLine()) != "stats time")
        {
            string[] info = input.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] data = info[0].Split(':');

            if (data[0] == ("like"))
            {
                string video = data[1];
                int like = 0;

                if (!likes.ContainsKey(video))
                {
                    likes.Add(video, like);
                    likes[video] += 1;
                }
                else
                {
                    likes[video] += 1;
                }
            }
            else if (data[0] == "dislike")
            {
                string video = data[1];
                if (likes.ContainsKey(video))
                {
                    likes[video] -= 1;
                }
            }

            else
            {
                string videoName = info[0];
                int views = int.Parse(info[1]);

                if (!videos.ContainsKey(videoName))
                {
                    videos.Add(videoName, views);
                }
                else
                {
                    videos[videoName] += views;

                }

                if (!likes.ContainsKey(videoName))
                {
                    likes[videoName] = 0;
                }
            }
        }
        input = Console.ReadLine();

        if (input == "by likes")
        {
            foreach (var pair in likes.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(($"{pair.Key} - {videos[pair.Key]} views - {pair.Value} likes"));
            }
        }
        else if (input == "by views")
        {
            foreach (var pair in videos.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} views - {likes[pair.Key]} likes");
            }
        }
    }
}

