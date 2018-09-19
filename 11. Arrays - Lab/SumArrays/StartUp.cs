namespace SumArrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var arrayInts1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var arrayInts2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();           

            var length1 = arrayInts1.Length;
            var length2 = arrayInts2.Length;
            var sumArrays = new int[Math.Max(length1, length2)];

            for (int i = 0; i <sumArrays.Length; i++)
            {
                sumArrays[i] = arrayInts1[i % length1] + arrayInts2[i % length2];
            }

            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}
