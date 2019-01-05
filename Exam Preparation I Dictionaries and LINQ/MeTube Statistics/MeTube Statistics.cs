using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Dictionary<string, int> videos = new Dictionary<string, int>();
        Dictionary<string, int> likes = new Dictionary<string, int>();
        string input;

        while ((input = Console.ReadLine()) != "stats time")
        {
            string[] info = input.Split(new string[] { "-", ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string videoName = info[0];

            if (info[0] == "like" || info[0] == "dislike")
            {
                if (info[0] == "like")
                {
                    string video = info[1];
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

                else if (info[0] == "dislike")
                {
                    string video = info[1];

                    if (likes.ContainsKey(video))
                    {
                        likes[video] -= 1;
                    }
                }
            }
            else
            {
                int views = int.Parse(info[1]);

                if (!videos.ContainsKey(videoName))
                {
                    videos.Add(videoName, views);
                }
                else
                {
                    videos[videoName] += views;
                }
            }
        }
        input = Console.ReadLine();

        if (input == "by likes")
        {
            foreach (var pair in likes.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} -  views {string.Join(" ", pair.Value)} likes");
            }
        }
        else if (input == "by views")
        {
            foreach (var pair in videos.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} - {string.Join(" ", pair.Value)} views - ");
                
            }
        }
    }
}

