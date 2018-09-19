namespace FoldAndSum
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

            var length = array.Length / 4;

            var arrayLeft = array.Take(length).Reverse().ToArray();
            var arrayRight = array.Skip(length * 3).Take(length).Reverse().ToArray();

            var arrayMid = array.Skip(length).Take(length * 2).ToArray();
            var arraySum = new int[length * 2];

            for (int i = 0; i < arrayLeft.Length; i++)
            {
                arraySum[i] += arrayLeft[i];
            }
            for (int i = 0; i < length; i++)
            {            
                arraySum[i + length] += arrayRight[i];
            }
            for (int i = 0; i < arrayMid.Length; i++)
            {
                arraySum[i] += arrayMid[i];
            }
            
            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
