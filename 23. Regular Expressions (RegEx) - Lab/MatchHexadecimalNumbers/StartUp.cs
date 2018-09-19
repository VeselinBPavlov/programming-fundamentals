namespace MatchHexadecimalNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var hexNumbers = Console.ReadLine();
            var pattern = @"\b(0x)?([0-9A-F]+)\b";

            var matches = Regex.Matches(hexNumbers, pattern);

            var validHexNums = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", validHexNums));
        }
    }
}
