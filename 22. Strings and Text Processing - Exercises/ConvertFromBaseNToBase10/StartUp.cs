namespace ConvertFromBaseNToBase10
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            var baseSystem = input[0];
            var number = input[1].Reverse().ToArray();
            BigInteger sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString()) * NotMathPow(baseSystem, i);
            }

            Console.WriteLine(sum);
        }

        public static BigInteger NotMathPow(string num, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            var bigIntNum = BigInteger.Parse(num);
            BigInteger result = bigIntNum;
            for (int i = 1; i < power; i++)
            {
                result *= bigIntNum;
            }
            return result;
        }
    }
}
