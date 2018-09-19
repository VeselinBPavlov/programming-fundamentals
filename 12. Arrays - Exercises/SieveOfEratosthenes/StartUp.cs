namespace SieveOfEratosthenes
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var isPrime = new bool[number + 1];

            for (int i = 0; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < isPrime.Length; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            List<int> result = new List<int>();

            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
