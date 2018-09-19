namespace SumBigNumbers
{
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int length = Math.Max(firstNumber.Length, secondNumber.Length);
            firstNumber = firstNumber.PadLeft(length, '0');
            secondNumber = secondNumber.PadLeft(length, '0');

            var sum = new StringBuilder();
            int mindNumber = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int digitSum = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString()) + mindNumber;
                mindNumber = 0;
                if (digitSum > 9)
                {
                    digitSum -= 10;
                    mindNumber++;
                    if (i == 0)
                    {
                        sum.Append(digitSum);
                        sum.Append("1");
                        break;
                    }
                }

                sum.Append(digitSum);
            }
            var result = new string(sum.ToString().Reverse().SkipWhile(x => x == '0').ToArray());
            Console.WriteLine(result);
        }
    }
}
