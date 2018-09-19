namespace TripleSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var tripleSum = 0;
            var isAnySum = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    tripleSum = array[i] + array[j];

                    if (array.Contains(tripleSum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {tripleSum}");
                        isAnySum = true;
                    }
                }
            }
            if (!isAnySum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
