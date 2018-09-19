namespace CharacterMultiplier
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var firstWord = inputLine[0].ToCharArray();
            var secondWord = inputLine[1].ToCharArray();
            var sum = 0;

            var length = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < length; i++)
            {
                sum += (int)firstWord[i] * secondWord[i];
            }

            if (firstWord.Length > secondWord.Length)
            {
                firstWord = firstWord.Skip(length).Take(firstWord.Length).ToArray();
                foreach (var character in firstWord)
                {
                    sum += (int)character;
                }
            }
            else if (firstWord.Length < secondWord.Length)
            {
                secondWord = secondWord.Skip(length).Take(secondWord.Length).ToArray();
                foreach (var character in secondWord)
                {
                    sum += (int)character;
                }
            }

            Console.WriteLine(sum);
        }
    }
}