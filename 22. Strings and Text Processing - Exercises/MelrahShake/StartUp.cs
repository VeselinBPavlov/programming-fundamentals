namespace MelrahShake
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                var firstIndex = input.IndexOf(pattern);
                var secondIndex = input.LastIndexOf(pattern);

                if (firstIndex >= 0 && secondIndex >= 0 || firstIndex != secondIndex)
                {
                    input = input.Remove(secondIndex, pattern.Length);
                    input = input.Remove(firstIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
