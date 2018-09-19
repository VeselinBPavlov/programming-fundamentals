namespace SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(",;:.!()\"'\\/[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var upperCase = new List<string>();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();

            foreach (var word in words)
            {
                word.ToCharArray();

                var isLower = true;
                var isUpper = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if ( 'A' > word[i] || word[i] > 'Z')
                    {
                        isUpper = false;
                        break;
                    }                   
                }
                if (isUpper)
                {
                    upperCase.Add(word.ToString());
                    continue;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    if ('a' > word[i] || word[i] > 'z')
                    {
                        isLower = false;
                        break;
                    }
                }
                if (isLower)
                {
                    lowerCase.Add(word.ToString());
                    continue;
                }

                mixedCase.Add(word.ToString());
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
