namespace FastPrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool primeNumber = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {primeNumber}");
            }
        }
    }
}