namespace RandomizeWords
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var rnd = new Random();

            for (int i = 0; i < input.Length - 1; i++)
            {
                int index = rnd.Next(0, input.Length);
                var word = input[index];
                var newIndex = rnd.Next(0, input.Length);
                input[index] = input[newIndex];
                input[newIndex] = word;
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    } 
}