namespace ConvertFromBase10ToBaseN
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var baseSystemNum = byte.Parse(inputLine[0]);
            var base10Num = BigInteger.Parse(inputLine[1]);
            var result = new StringBuilder();

            while (base10Num > 0)
            {
                var number = (BigInteger)base10Num % baseSystemNum;
                result.Append(number.ToString());
                base10Num /= (BigInteger)baseSystemNum;                
            }

            var reverserdNum = result.ToString().ToCharArray().Reverse();

            Console.WriteLine(string.Join("", reverserdNum));
        }
    }
}
