namespace EqualSums
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

            bool isFindEqualSums = false;

            for (int i = 0; i < array.Length; i++)
            {
                var leftSideArr = array.Take(i).ToArray();
                var rightSideArr = array.Skip(i + 1).ToArray();

                if (leftSideArr.Sum() == rightSideArr.Sum())
                {
                    Console.WriteLine(i);
                    isFindEqualSums = true;
                    break;
                }
            }
            if (!isFindEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
