namespace StringsAndObjects
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            string thirdWord = firstWord + " " + secondWord;

            Console.WriteLine(thirdWord);
        }
    }
}