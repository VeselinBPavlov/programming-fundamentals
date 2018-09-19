namespace Sign_Of_Integer_Number
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSngn(n);
        }

        static void PrintSngn(int n)
        {
            if (n > 0)
                Console.WriteLine($"The number {n} is positive.");
            else if (n < 0)
                Console.WriteLine($"The number {n} is negative.");
            else
                Console.WriteLine($"The number {n} is zero.");
        }
    }
}