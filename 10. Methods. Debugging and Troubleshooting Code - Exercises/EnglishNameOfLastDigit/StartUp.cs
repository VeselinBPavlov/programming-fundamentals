namespace EnglishNameOfLastDigit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] digitName = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string digit = Console.ReadLine();
            Console.WriteLine(digitName[int.Parse(digit[digit.Length - 1].ToString())]);
        }
    }
}