namespace Substring
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            int counter   = int.Parse(Console.ReadLine());

            const char letter = 'p';
            bool hasMatch = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    hasMatch = true;
                    int endIndex = counter + 1 > word.Length - i ? word.Length - i : counter + 1;
                    string matchedString = word.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += counter;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
