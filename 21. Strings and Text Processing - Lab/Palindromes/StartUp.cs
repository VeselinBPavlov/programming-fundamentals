namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(" ,.!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var reversedText = text
                .Select(x => string.Join("", x.Reverse()))
                .ToArray();

            var palidromeWords = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == reversedText[i])
                {
                    if (!palidromeWords.Contains(text[i]))
                    {
                        palidromeWords.Add(text[i]);
                    }
                }
            }           

            Console.WriteLine(string.Join(", ", palidromeWords.OrderBy(x => x)));
        }
    }
}
