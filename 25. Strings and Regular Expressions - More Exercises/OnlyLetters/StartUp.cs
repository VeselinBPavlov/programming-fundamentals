namespace OnlyLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;


    public class StartUp
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var pattern = @"(\d+)([A-Za-z])";
            var message = new StringBuilder();
            message.Append(inputString);

            while (true)
            {
                inputString = message.ToString();
                var match = Regex.Match(inputString, pattern);

                if (match.Success)
                {
                    var number = match.Groups[1].Value;
                    var letter = match.Groups[2].Value;
                    
                    var index = inputString.IndexOf(number);
                    message.Replace(number, letter);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(message);
        }
    }
}
