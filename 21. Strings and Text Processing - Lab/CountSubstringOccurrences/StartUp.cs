namespace CountSubstringOccurrences
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var counter = 0;
            int index = -1;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);

                if (index == -1)
                {
                    break;
                }

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}