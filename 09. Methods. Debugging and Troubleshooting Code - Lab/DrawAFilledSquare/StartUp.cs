namespace DrawAFilledSquare
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeader(n);

            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddle(n);
            }

            PrintHeader(n);
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine("{0}", new string('-', 2 * n));
        }

        static void PrintMiddle(int n)
        {
            Console.Write("-");

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }
}