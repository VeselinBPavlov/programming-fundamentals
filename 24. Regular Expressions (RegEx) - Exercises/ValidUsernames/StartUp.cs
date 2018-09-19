namespace ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            var pattern = @"\b[a-zA-Z]\w{2,24}\b";            
            var validUsers = new List<string>();

            foreach (var word in input)
            {
                var match = Regex.Match(word, pattern);
                if (match.Success)
                {
                    validUsers.Add(word);
                }
            }

            var bestIndex = 0;
            var bestCount = 0;
            var count = 0;

            for (int i = 0; i < validUsers.Count - 1; i++)
            {
                count = validUsers[i].Length + validUsers[i + 1].Length;

                if (count > bestCount)
                {
                    bestCount = count;
                    bestIndex = i;
                }
            }

            Console.WriteLine(validUsers[bestIndex]);
            Console.WriteLine(validUsers[bestIndex + 1]);
        }
    }
}
