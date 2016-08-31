namespace FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FootballLeague
    {
        static void Main(string[] args)
        {
            var encryptionString = Console.ReadLine();
            var input = Console.ReadLine();
            Dictionary<string, int> resultsDictionary = new Dictionary<string, int>(); //dictionary for the top goal countries
            Dictionary<string, int> placementDictionary = new Dictionary<string, int>(); //dictionary for the overral placement for the countries
            while (input != "final")
            {
                var arguments = input.Split(' '); //split the input in 3 parts - 1st team / 2nd team / score

                var index = arguments[0].IndexOf(encryptionString); //find the start of the encrypted string for the substring
                var team1 = arguments[0].Substring(index + encryptionString.Length); //extract the team, but there are leftovers at the end
                index = team1.IndexOf(encryptionString);  //find the leftover string
                team1 = team1.Substring(0, index).ToUpperInvariant(); //remove it
                team1 = new string(team1.Reverse().ToArray()); //extract the correct team name
                //now we do the same for the 2nd team
                index = arguments[1].IndexOf(encryptionString); 
                var team2 = arguments[1].Substring(index + encryptionString.Length);
                index = team2.IndexOf(encryptionString);
                team2 = team2.Substring(0, index).ToUpperInvariant();
                team2 = new string(team2.Reverse().ToArray());

                var score = arguments[2].Split(':');
                //get the score and aggregate the points
                var team1Goals = int.Parse(score[0]);
                var team2Goals = int.Parse(score[1]);


                int team1Points = 0;
                int team2Points = 0;
                if (team1Goals == team2Goals)
                {
                    team1Points = 1;
                    team2Points = 1;
                }
                else if (team1Goals > team2Goals)
                {
                    team1Points = 3;
                    team2Points = 0;
                }
                else
                {
                    team1Points = 0;
                    team2Points = 3;
                }

                //insert or update the data in the dictionary for the respective teams
                if (!resultsDictionary.ContainsKey(team1))
                {
                    resultsDictionary.Add(team1, team1Goals);
                    placementDictionary.Add(team1, team1Points);
                }

                else
                {
                    resultsDictionary[team1] += team1Goals;
                    placementDictionary[team1] += team1Points;
                }

                if (!resultsDictionary.ContainsKey(team2))
                {
                    resultsDictionary.Add(team2, team2Goals);
                    placementDictionary.Add(team2, team2Points);
                }
                else
                {
                    resultsDictionary[team2] += team2Goals;
                    placementDictionary[team2] += team2Points;
                }

                input = Console.ReadLine();
            }

            //placement
            int placement = 1;
            Console.WriteLine("League standings:");
            foreach (var pairs in placementDictionary.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine("{0}. {1} {2}", placement++, pairs.Key, pairs.Value);
            }

            //goals
            Console.WriteLine("Top 3 scored goals:");
            foreach (var pairs in resultsDictionary.OrderByDescending(s => s.Value).ThenBy(s => s.Key).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", pairs.Key, pairs.Value);
            }

        }
    }
}
