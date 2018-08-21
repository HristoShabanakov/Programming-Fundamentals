using System;
using System.Collections.Generic;
using System.Linq;


class MOBAChallenger
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
        //Create a list which will hold all the players.
        List<string> playersList = new List<string>();
        string input = Console.ReadLine();

        while (input != "Season end")
        {
            if (input.Contains("->"))
            {
                string[] command = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string player = command[0];
                string position = command[1];
                int skill = int.Parse(command[2]);

                if (!players.ContainsKey(player))
                //When you receive a player and his position and skill, 
                //add him to the player pool,if he isn`t present.
                {
                    players.Add(player, new Dictionary<string, int>());
                    players[player].Add(position, skill);
                    playersList.Add(player);
                }

                else
                  //else add his position and skill or update his skill, 
                {
                    if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);
                    }
                    else
                    ////only if the current position skill is lower than the new value.
                    {
                        int skillPoints = players[player][position];
                        if (skillPoints < skill)
                        {
                            players[player][position] = skill;
                        }
                    }
                }
            }

            if (input.Contains("vs"))
            {
                string[] command = input
                    .Split(new string[] { " vs " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string playerOne = command[0];
                string playerTwo = command[1];

                if (playersList.Contains(playerOne) && playersList.Contains(playerTwo))
                {
                    int skillPoints1 = 0;
                    int skillPoints2 = 0;
                    //Compare their positions, if they got a common position.
                    foreach (var player1 in players[playerOne])
                    {
                        foreach (var player2 in players[playerTwo])
                        {
                            if (player1.Key == player2.Key)
                            //Calculate their points.
                            {
                                skillPoints1 = players[playerOne].Values.Sum();
                                skillPoints2 = players[playerTwo].Values.Sum();
                            }
                        }
                    }
                    //the player with better total skill points wins and the other has to removed from the list.
                    if (skillPoints1 > skillPoints2)
                    {
                        players.Remove(playerTwo);
                        playersList.Remove(playerTwo);
                    }
                    else if (skillPoints1 < skillPoints2)
                    {
                        players.Remove(playerOne);
                        playersList.Remove(playerOne);
                    }
                }
            }
            input = Console.ReadLine();
        }
        //Print the players, ordered by total skill in desecending order, then ordered by player name in ascending order.
        foreach (var pair in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value.Values.Sum()} skill");
            //Foreach player print their position and skill, ordered desecending by skill, 
            //then ordered by position name in ascending order.
            foreach (var item in pair.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"- {item.Key} <::> {item.Value}");
            }
        }
    }
}
