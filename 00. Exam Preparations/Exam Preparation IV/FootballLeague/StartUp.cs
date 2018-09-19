namespace FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var command = Console.ReadLine();

            var standings = new Dictionary<string, int>();
            var teamGoals = new Dictionary<string, int>();

            while (!command.Equals("final"))
            {
                var commandArgs = command.Split();
                var firstTeamName = GetTeamName(commandArgs[0], key);
                var secondTeamName = GetTeamName(commandArgs[1], key);

                var score = commandArgs[2].Split(':');
                var firstTeamGoals = int.Parse(score[0]);
                var secondTeamGoals = int.Parse(score[1]);

                if (firstTeamGoals > secondTeamGoals)
                {
                    AddScoreToTeam(standings, firstTeamName, 3);
                    AddScoreToTeam(standings, secondTeamName, 0);
                }
                else if (firstTeamGoals < secondTeamGoals)
                {
                    AddScoreToTeam(standings, firstTeamName, 0);
                    AddScoreToTeam(standings, secondTeamName, 3);
                }
                else
                {
                    AddScoreToTeam(standings, firstTeamName, 1);
                    AddScoreToTeam(standings, secondTeamName, 1);
                }

                AddScoreToTeam(teamGoals, firstTeamName, firstTeamGoals);
                AddScoreToTeam(teamGoals, secondTeamName, secondTeamGoals);

                command = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            var sorted = standings.OrderByDescending(t => t.Value).ThenBy(t => t.Key);
            var count = 1;
            foreach (var team in sorted)
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");
            var sortedGoals = teamGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3);
            foreach (var team in sortedGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
                count++;
            }
        }

        public static void AddScoreToTeam(Dictionary<string, int> standings, string firstTeamName, int firstTeamScore)
        {
            if (!standings.ContainsKey(firstTeamName))
            {
                standings.Add(firstTeamName, 0);
            }

            standings[firstTeamName] += firstTeamScore;
        }

        public static string GetTeamName(string teamName, string key)
        {
            var firstIndex = teamName.IndexOf(key) + key.Length;
            var secondIndex = teamName.LastIndexOf(key);
            var length = secondIndex - firstIndex;
            var name = teamName.Substring(firstIndex, length);
            return string.Join("", name.ToUpper().Reverse());
        }
    }
}
