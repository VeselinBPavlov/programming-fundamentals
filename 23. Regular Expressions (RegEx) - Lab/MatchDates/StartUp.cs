namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var dateList = Console.ReadLine();
            var pattern = @"\b(?<day>\d{2})(.|-|\/)(?<month>[A-z][a-z]{2})(\1)(?<year>\d{4})\b";

            var validDates = Regex.Matches(dateList, pattern);

            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
