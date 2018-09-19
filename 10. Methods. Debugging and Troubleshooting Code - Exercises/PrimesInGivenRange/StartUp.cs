namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum   = int.Parse(Console.ReadLine());

            string numbers = String.Join(", ", FindPrimesInRange(startNum, endNum).ToArray());

            Console.WriteLine(numbers);
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var result = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                if (i < 2)
                    isPrime = false;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
