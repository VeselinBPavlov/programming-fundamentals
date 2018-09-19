namespace LargestCommonEnd
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arrayFirst = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var arraySecond = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var length = Math.Min(arrayFirst.Length, arraySecond.Length);

            var counter1 = 0;
            var counter2 = 0;

            for (int i = 0; i < length; i++)
            {
                if (arrayFirst[i] == arraySecond[i])
                    counter1++;
                else
                    break;
            }

            arrayFirst = arrayFirst.Reverse().ToArray();
            arraySecond = arraySecond.Reverse().ToArray();

            for (int i = 0; i < length; i++)
            {
                if (arrayFirst[i] == arraySecond[i])
                    counter2++;
                else
                    break;
            }

            Console.WriteLine(counter1 >= counter2 ? counter1 : counter2);
        }
    }
}