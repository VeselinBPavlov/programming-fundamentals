namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = 0.00M;

            foreach (var expression in inputLine)
            {
                var numString = expression.Substring(1, expression.Length - 2);
                var number = decimal.Parse(numString);                
                var firstChar = expression.First();
                var secondChar = expression.Last();
                var tempResult = 0.00M;

                if ('A' <= firstChar && firstChar <= 'Z')
                {
                    tempResult = number / (firstChar - 64);
                }
                else
                {
                    tempResult = number * (firstChar - 96);
                }

                if ('A' <= secondChar && secondChar <= 'Z')
                {
                    tempResult = tempResult - (secondChar - 64);
                }
                else
                {
                    tempResult = tempResult + (secondChar - 96);
                }

                result += tempResult;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
