namespace KeyReplacer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var keyString = Console.ReadLine();
            var textString = Console.ReadLine();
            var sentence = new List<string>();

            var startPattern = @"^([A-Za-z]+)[|<\\]";
            var endPattern = @"[|<\\]([A-Za-z]+)$";

            var startMatch = Regex.Match(keyString, startPattern);
            var endMatch = Regex.Match(keyString, endPattern);

            var startWord = startMatch.Groups[1].Value;
            var endWord = endMatch.Groups[1].Value;

            var matchPattern = $@"({startWord})([a-zA-z]*?)({endWord})";
            var matches = Regex.Matches(textString, matchPattern);

            foreach (Match match in matches)
            {                
                var word = match.Groups[2].Value;
                if (word != string.Empty)
                {
                    sentence.Add(word);
                }                
            }

            if (sentence.Any())
            {
                Console.WriteLine(string.Join("", sentence));
            }
            else
            {
                Console.WriteLine("Empty result");
            }            
        }
    }
}
