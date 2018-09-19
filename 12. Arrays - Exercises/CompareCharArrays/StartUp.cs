using System;
using System.Linq;

namespace CompareCharArrays
{
    public class StartUp
    {
        public static void Main()
        {
            var arrayFirst = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            var arraySecond = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            var length = Math.Min(arrayFirst.Length, arraySecond.Length);

            for (int i = 0; i < length; i++)
            {
                if (arrayFirst[i] == arraySecond[i])
                {
                    continue;
                }

                if (arrayFirst[i] < arraySecond[i])
                {
                    Console.WriteLine(string.Join("", arrayFirst));
                    Console.WriteLine(string.Join("", arraySecond));
                    return;
                }
                else
                {
                    Console.WriteLine(string.Join("", arraySecond));
                    Console.WriteLine(string.Join("", arrayFirst));                    
                    return;
                }               
            }

            if (arrayFirst.Length <= arraySecond.Length)
            {
                Console.WriteLine(string.Join("", arrayFirst));
                Console.WriteLine(string.Join("", arraySecond));
            }
            else
            {
                Console.WriteLine(string.Join("", arraySecond));
                Console.WriteLine(string.Join("", arrayFirst));
            }
        }
    }
}