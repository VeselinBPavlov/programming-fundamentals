namespace Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var surfaceRegex = @"^([^A-Za-z0-9]+)$";
            var mentaleRegex = @"^([0-9_]+)$";
            var coreRegex = @"^([^A-Za-z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";
            var coreLength = 0;
            var isValid = true;

            for (int i = 1; i <= 5; i++)
            {
                var snowflakePart = Console.ReadLine();

                if (i == 1 || i == 5)
                {
                    var match = Regex.Match(snowflakePart, surfaceRegex);
                    if (match.Success == false)
                    {
                        isValid = false;
                        continue;
                    }
                }

                if (i == 2 || i == 4)
                {
                    var match = Regex.Match(snowflakePart, mentaleRegex);
                    if (match.Success == false)
                    {
                        isValid = false;
                        continue;
                    }
                }

                if (i == 3)
                {
                    var match = Regex.Match(snowflakePart, coreRegex);
                    if (match.Success == false)
                    {
                        isValid = false;
                        continue;
                    }

                    var core = match.Groups[3].Value;
                    coreLength = core.Length;
                }
            }

            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            
        }
    }
}
