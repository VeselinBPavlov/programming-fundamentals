namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var logs = int.Parse(Console.ReadLine());

            var userLogs = new SortedDictionary<string, int>();
            var userIPs = new Dictionary<string, List<string>>();

            for (int i = 0; i < logs; i++)
            {
                var userData = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var ip = userData[0];
                var user = userData[1];
                var duration = int.Parse(userData[2]);

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, duration);
                    userIPs.Add(user, new List<string>());
                    userIPs[user].Add(ip);
                }
                else
                {
                    if (!userIPs[user].Contains(ip))
                    {
                        userIPs[user].Add(ip);
                    }

                    userLogs[user] += duration;
                }
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: {user.Value} [{string.Join(", ", userIPs[user.Key].OrderBy(x => x))}]");
            }
        }
    }
}
