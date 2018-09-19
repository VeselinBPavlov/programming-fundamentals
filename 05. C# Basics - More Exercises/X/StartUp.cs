namespace X
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', i), new string(' ', (n - 2) - (i + i)));
            }

            Console.WriteLine("{0}x", new string(' ', n / 2));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', ((n / 2) - 1) - i), new string(' ', 1 + (i + i)));
            }
        }
    }
}
