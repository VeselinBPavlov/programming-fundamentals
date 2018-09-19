namespace RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().ToUpper();
            var pattern = @"(\D+)(\d+)";
            var tempMessage = new StringBuilder();
            var matches = Regex.Matches(inputLine, pattern);         

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    var word = match.Groups[1].Value.ToCharArray();
                    var number = int.Parse(match.Groups[2].Value);

                    for (int i = 0; i < number; i++)
                    {
                       tempMessage.Append(word);
                    }
                }         
            }

            var message = tempMessage.ToString();
            var uniqueSymbols = message.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(message);
        }
    }
}
