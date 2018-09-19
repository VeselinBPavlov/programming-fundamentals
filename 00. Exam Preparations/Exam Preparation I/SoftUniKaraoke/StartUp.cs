namespace SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var participans = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            var songs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            var command = Console.ReadLine();

            var ranking = new Dictionary<string, List<string>>();

            while (command != "dawn")
            {
                var performance = command
                     .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => x.Trim())
                     .ToArray();

                var participant = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (!participans.Contains(participant) || !songs.Contains(song) || performance.Length < 3)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (ranking.ContainsKey(participant) == false)
                {
                    ranking.Add(participant, new List<string>());
                }

                if (ranking[participant].Contains(award) == false)
                {
                    ranking[participant].Add(award);
                }

                command = Console.ReadLine();
            }

            if (ranking.Any())
            {
                foreach (var participant in ranking.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                    foreach (var award in participant.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
