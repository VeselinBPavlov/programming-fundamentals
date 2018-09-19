namespace PrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long num = long.Parse(Console.ReadLine());

            if (IsPrime(num))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}