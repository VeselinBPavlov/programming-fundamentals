namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"(^|(?<=\s))([a-z0-9]+(\.|-|_)?[a-z0-9]+)@(([a-z]+[-]?[a-z]+?[.-]?[a-z]+?)\.([a-z]+)\.?[a-z]+)\b";

            var validEmails = Regex.Matches(text, pattern);

            foreach (Match email in validEmails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
