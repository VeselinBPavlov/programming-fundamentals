namespace GreaterOfTwoValues
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int number1         = int.Parse(Console.ReadLine());
                    int number2         = int.Parse(Console.ReadLine());
                    int resultInt       = GetMaxInt(number1, number2);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char char1          = char.Parse(Console.ReadLine());
                    char char2          = char.Parse(Console.ReadLine());
                    char resultChar     = GetMaxChar(char1, char2);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string string1      = Console.ReadLine();
                    string string2      = Console.ReadLine();
                    string resultString = GetMaxString(string1, string2);
                    Console.WriteLine(resultString);
                    break;
            }
        }

       static string GetMaxString(string string1, string string2)
       {
           if (string1.CompareTo(string2) >= 0)
               return string1;
           else
               return string2;
       }

        static int GetMaxInt(int number1, int number2)
        {
            if (number1 >= number2)
                return number1;
            else
                return number2;
        }

        static char GetMaxChar(char char1, char char2)
        {
            if (char1 >= char2)
                return char1;
            else
                return char2;
        }
    }
}