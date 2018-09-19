namespace SrubskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var output = new Dictionary<string, Dictionary<string, long>>();

            while (command != "End")
            {
                var singer = command.Split('@').First();

                var concertData = command.Substring(command.IndexOf('@') + 1);

                if (!singer.EndsWith(" ") || singer.Length < 2)
                {
                    command = Console.ReadLine();
                    continue;
                }
                singer = singer.Trim();
                var concertDataList = concertData.Split(' ').ToList();

                if (!int.TryParse(concertDataList[concertDataList.Count - 1], out int ticketCount) ||
                    !int.TryParse(concertDataList[concertDataList.Count - 2], out int ticketPrice) ||
                    concertDataList.Count < 3)
                {
                    command = Console.ReadLine();
                    continue;
                }

                var venue = string.Join(" ",
                    concertDataList.Take(concertDataList.Count - 2));

                if (!output.ContainsKey(venue))
                {
                    output[venue] = new Dictionary<string, long>();
                }
                if (!output[venue].ContainsKey(singer))
                {
                    output[venue][singer] = 0;
                }
                output[venue][singer] += ticketPrice * ticketCount;
                output[venue] = output[venue]
                    .OrderByDescending(p => p.Value)
                    .ToDictionary(k => k.Key, p => p.Value);

                command = Console.ReadLine();
            }

            foreach (var venue in output)
            {
                Console.WriteLine(venue.Key);
                Console.WriteLine(string.Join(Environment.NewLine, venue.Value.Select(s => $"#  {s.Key} -> {s.Value}")));
            }
        }
    }
}
