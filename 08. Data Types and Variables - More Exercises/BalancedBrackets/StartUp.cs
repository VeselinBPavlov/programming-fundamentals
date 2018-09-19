namespace BalancedBrackets
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int firstBracket = 0;
            int secondBracket = 0;
            bool closingBrackets = false;

            for (int i = 0; i < num; i++)
            {
                string character = Console.ReadLine();
                if (character.Length == 1)
                {
                    char currentChar = char.Parse(character);
                    firstBracket += currentChar == '(' ? (int)1 : (int)0;
                    secondBracket += currentChar == ')' ? (int)1 : (int)0;
                    if (!(firstBracket == secondBracket || firstBracket == secondBracket + 1))
                    {
                        closingBrackets = true;
                    }
                }
            }
            bool isBalanced = firstBracket == secondBracket;
            Console.WriteLine(isBalanced && !closingBrackets ? "BALANCED" : "UNBALANCED");
        }
    }
}
