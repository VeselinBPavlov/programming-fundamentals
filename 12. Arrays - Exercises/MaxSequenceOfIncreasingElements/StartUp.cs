namespace MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var array = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int start = 0;
            int lenght = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    lenght++;

                    if (lenght > bestLength)
                    {
                        bestLength = lenght;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    lenght = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}