namespace PrintingTriangle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(1, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }

        static void PrintTriangle(int start, int end)
        {
           for (int i = start; i <= end; i++)
           {
                Console.Write("{0} ", i);
           }
                Console.WriteLine();
        }
    }
}