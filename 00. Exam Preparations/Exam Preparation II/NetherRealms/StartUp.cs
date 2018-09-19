namespace NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var demonsList = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            var demonsBook = new SortedDictionary<string, List<double>>();

            foreach (var demon in demonsList)
            {
                var demonSigns = demon.ToCharArray();
                var health = demonSigns
                    .Where(x => x != '+' && x != '-' && x != '*' && x != '/' && (x < '0' || x > '9') && x != '.')
                    .Select(x => Convert.ToInt32(x))
                    .Sum();

                var damage = 0.00;

                if (demon.Contains(',') || demon.Contains(' ') || health == 0)
                {
                    continue;
                }

                var numberPattern = @"[+-]?(\d+)(\.\d+)?";

                var matches = Regex.Matches(demon, numberPattern);

                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Value);
                }

                var multDiv = demon.Where(x => x == '/' || x == '*').ToArray();

                if (multDiv.Any())
                {
                    for (int i = 0; i < multDiv.Length; i++)
                    {
                        if (multDiv[i] == '/')
                        {
                            damage /= 2;
                        }
                        else
                        {
                            damage *= 2;
                        }
                    }
                }

                demonsBook.Add(demon, new List<double>());
                demonsBook[demon].Add((double)health);
                demonsBook[demon].Add(damage);
            }

            foreach (var demon in demonsBook)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}
