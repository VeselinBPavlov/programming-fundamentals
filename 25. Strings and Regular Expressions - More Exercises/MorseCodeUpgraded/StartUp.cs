namespace MorseCodeUpgraded
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var morseCode = Console.ReadLine().Split('|') .ToArray();
            var message = new List<char>();

            for (int i = 0; i < morseCode.Length; i++)
            {
                var code = morseCode[i].ToCharArray();
                var ones = code.Where(x => x == '1').ToList().Count;
                var zeros = code.Where(x => x == '0').ToList().Count;
                var tempResult = (ones * 5) + (zeros * 3);
                var counter = 1;

                for (int j = 0; j < code.Length - 1; j++)
                {
                    if (code[j] == code[j + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter > 1)
                        {
                            tempResult += counter;
                        }                        
                        counter = 1;
                    }
                }

                if (counter > 1)
                {
                    tempResult += counter;
                }

                message.Add((char)tempResult);
            }

            Console.WriteLine(string.Join("", message));
        }
    }
}
