namespace UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                var inputLine = input
                    .Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var ip = inputLine[1];
                var user = inputLine[5];

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                    userLogs[user].Add(ip, 1);
                }
                else
                {
                    if (!userLogs[user].ContainsKey(ip))
                    {
                        userLogs[user].Add(ip, 1);
                    }
                    else
                    {
                        userLogs[user][ip]++;
                    }                    
                }                

                input = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine($"{string.Join(", ", user.Value.Select(x => $"{x.Key} => {x.Value}"))}.");
            }
        }
    }
}
