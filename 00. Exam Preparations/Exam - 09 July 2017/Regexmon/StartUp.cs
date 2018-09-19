namespace Regexmon
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var pattern = @"([^A-Za-z-]+)([A-Za-z]+-[A-Za-z]+)?";
            var regexDidimon = @"[^A-Za-z-]+";
            var regexBojomon = @"[A-Za-z]+-[A-Za-z]+";
            var pokeMatches = new List<string>();

            var matches = Regex.Matches(inputLine, pattern);
            var tempMatches = new List<string>();

            foreach (Match match in matches)
            {
                tempMatches.Add(match.Value);
            }

            var isMatched = true;

            for (int i = 0; i < tempMatches.Count; i++)
            {
                if (isMatched)
                {
                    var matchDidi = Regex.Match(tempMatches[i], regexDidimon);
                    if (matchDidi.Success)
                    {
                        Console.WriteLine(matchDidi.Value);
                    }

                    var matchBojo = Regex.Match(tempMatches[i], regexBojomon);

                    if (matchBojo.Success)
                    {
                        Console.WriteLine(matchBojo.Value);
                        isMatched = true;
                    }
                    else
                    {
                        isMatched = false;
                    }
                }
                else
                {
                    var matchBojo = Regex.Match(tempMatches[i], regexBojomon);

                    if (matchBojo.Success)
                    {
                        Console.WriteLine(matchBojo.Value);
                        isMatched = true;
                    }
                }                
            }
        }
    }
}