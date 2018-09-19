namespace MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine();
            var pattern = @"\+359(\s|-)2(\1)\d{3}(\1)\d{4}\b";

            var matches = Regex.Matches(phoneNumbers, pattern);

            var validPhones = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}
