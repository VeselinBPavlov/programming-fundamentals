namespace ReversedChars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{letter3}{letter2}{letter1}");
        }
    }
}