namespace SumOfChars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int characters = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < characters; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sum += (int)character;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
