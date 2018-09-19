namespace MatchNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine();
            var pattern = @"(^|(?<=\s))-?(\d+)(\.\d+)?($|(?=\s))";

            var matchesNums = Regex.Matches(numbersList, pattern);

            var validNumbers = matchesNums
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", validNumbers));
        }
    }
}
