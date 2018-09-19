namespace TextFilter
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var badWords = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var text = Console.ReadLine();

            foreach (var badWord in badWords)
            {                
                text = text.Replace(badWord, new string('*', badWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
