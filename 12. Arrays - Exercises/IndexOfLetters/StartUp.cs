namespace IndexOfLetters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine().ToCharArray();

            foreach (var letter in array)
            {
                var number = (int)letter - 97;
                Console.WriteLine($"{letter} -> {number}");
            }
        }
    }
}
