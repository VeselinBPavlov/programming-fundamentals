namespace VowelOrDigit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string symbol = Console.ReadLine();
            int digit = 0;

            try
            {
                digit = Int32.Parse(symbol);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                if (symbol == "a" || symbol == "o" || symbol == "u" || symbol == "e" || symbol == "i")
                    Console.WriteLine("vowel");
                else
                    Console.WriteLine("other");
            }
        }
    }
}