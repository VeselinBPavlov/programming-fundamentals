namespace ExtractSentencesByKeyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var pattern = $"\\b{keyWord}\\b";

            foreach (var sentence in text)
            {
                var match = Regex.Match(sentence, pattern);

                if (match.Success)
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
