namespace UnicodeCharacters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write($"\\u{(int)word[i]:x4}");
            }
            Console.WriteLine();
        }
    }
}
