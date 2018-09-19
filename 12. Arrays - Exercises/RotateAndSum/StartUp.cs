namespace RotateAndSum
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
            var rotationTimes = int.Parse(Console.ReadLine());

            var sumArrays = new int[array.Length];

            for (int i = 0; i < rotationTimes; i++)
            {
                var tempNum = array.Last();
                for (int j = array.Length - 1; j > 0; j--)
                {                    
                    array[j] = array[j - 1];                    
                }                 
                array[0] = tempNum;
                for (int j = 0; j < sumArrays.Length; j++)
                {
                    sumArrays[j] += array[j];
                }
            }

            Console.WriteLine(string.Join(" ", sumArrays));
        }
    }
}