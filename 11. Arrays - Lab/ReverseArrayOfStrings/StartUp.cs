namespace ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arrayStrings = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(" ", arrayStrings));
        }
    }
}
