namespace SMSTyping
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var iter = int.Parse(Console.ReadLine().Trim());
            var number = 0;
            var main = 0;
            var count = 0;
            var lc = 0;
            var fL = 'a';
            var text = string.Empty;

            for (int it = 0; it < iter; it++)
            {
                count = 0;
                number = int.Parse(Console.ReadLine().Trim());
                main = number % 10;
                if (main != 0)
                {
                    if (main <= 7)
                    {
                        fL = (char)('a' + ((main - 2) * 3));
                    }
                    else
                    {
                        fL = (char)('a' + 1 + ((main - 2) * 3));
                    }
                    lc = number.ToString().Length;
                    for (int i = 0; i < lc; i++)
                    {
                        count += number % 10;
                        number = number / 10;
                    }
                    count = count / main;
                    fL = (char)(fL - 1 + count);
                }
                else
                {
                    fL = ' ';
                }

                text = text + fL;
            }

            Console.WriteLine(text);
        }
    }
}
