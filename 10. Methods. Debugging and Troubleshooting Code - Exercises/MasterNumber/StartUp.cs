namespace MasterNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            string number = num.ToString();

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] == number[number.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }

            if (sum % 7 == 0)
                return true;
            else
                return false;
        }

        public static bool ContainsEvenDigit(int num)
        {
            string number = num.ToString();
            int rem = 0;

            for (int i = 0; i < number.Length; i++)
            {
                rem = int.Parse(number[i].ToString());
                if (rem % 2 == 0)
                    return true;
            }
                return false;
        }
    }
}
