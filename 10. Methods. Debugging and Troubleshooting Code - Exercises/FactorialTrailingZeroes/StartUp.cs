namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int zerosCount = TrailingZeros(number);

            Console.WriteLine(zerosCount);
        }

        public static BigInteger FindFactorial(BigInteger number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public static int TrailingZeros(BigInteger number)
        {
            string factorial = FindFactorial(number).ToString();
            int zerosCount = 0;

            for (int i = factorial.Length - 1; i >= 1; i--)
            {
                if (factorial[i] == '0')
                    zerosCount++;
                else
                    break;
            }
            return zerosCount;
        }
    }
}
