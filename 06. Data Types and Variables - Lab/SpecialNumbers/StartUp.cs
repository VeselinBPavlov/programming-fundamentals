namespace SpecialNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());           

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} -> ");

                int num1 = i % 10;
                int num2 = i / 10;
                int sum = num1 + num2;

                if (sum == 5 || sum == 7 || sum == 11)
                    Console.Write("True");
                else
                    Console.Write("False");

                Console.WriteLine();
            }
        }
    }
}
