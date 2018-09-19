namespace Censorship
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var censorWord = Console.ReadLine();
            var sentence = Console.ReadLine();

            var censoredSentence = string.Empty;            
            censoredSentence = sentence.Replace(censorWord, new string('*', censorWord.Length));

            Console.WriteLine(censoredSentence);
        }
    }
}
