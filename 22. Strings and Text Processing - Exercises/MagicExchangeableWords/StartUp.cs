namespace MagicExchangeableWords
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ').ToArray();

            var firstWord = inputLine[0].ToCharArray().Distinct().ToArray();
            var secondWord = inputLine[1].ToCharArray().Distinct().ToArray();

            Console.WriteLine(firstWord.Length == secondWord.Length ? "true" : "false");
        }
    }
}
