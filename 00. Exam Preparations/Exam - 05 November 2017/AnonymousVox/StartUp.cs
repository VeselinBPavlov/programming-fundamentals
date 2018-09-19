namespace AnonymousVox
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var encodedText = Console.ReadLine();
            var replaces = Console.ReadLine()
                .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var decodedText = new StringBuilder();
            var encodePattern = @"([A-Za-z]+)(.+)(\1)";

            decodedText.Append(encodedText);

            var matches = Regex.Matches(encodedText, encodePattern);

            foreach (Match match in matches)
            {
                if (replaces.Count < 1)
                {
                    break;
                }

                var decode = match.Groups[1] + replaces[0] + match.Groups[3];
                decodedText.Replace(match.Value, decode);                          
                replaces.RemoveAt(0);
            }           

            Console.WriteLine(decodedText);
        }
    }
}