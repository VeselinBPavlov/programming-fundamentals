namespace EmailStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var pattern = @"(^|(?<=\s))([A-Za-z]{5,})@([a-z]{3,})(.com|.bg|.org)($|(?=\s))";
            var emailRegister = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var email = Console.ReadLine();
                var match = Regex.Match(email, pattern);

                if (match.Success == false)
                {
                    continue;
                }

                var user = match.Groups[2].Value;
                var domain = match.Groups[3].Value + match.Groups[4].Value;

                if (emailRegister.ContainsKey(domain) == false)
                {
                    emailRegister.Add(domain, new List<string>());
                }

                if (emailRegister[domain].Contains(user) == false)
                {
                    emailRegister[domain].Add(user);
                }
            }

            foreach (var domain in emailRegister.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");
                Console.WriteLine($"{string.Join(Environment.NewLine, domain.Value.Select(x => $"### {x}"))}");
            }
        }
    }
}
