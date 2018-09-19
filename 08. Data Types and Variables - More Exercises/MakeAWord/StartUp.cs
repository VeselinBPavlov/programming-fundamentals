namespace MakeAWord
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int letters = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < letters; i++)
            {
                string letter = Console.ReadLine();
                word += letter;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
