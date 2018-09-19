namespace CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var condensed = new int[nums.Length - 1];

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                nums = FindSumArray(nums, condensed);
            }

            Console.WriteLine(nums[0]);
        }

        public static int[] FindSumArray(int[] nums, int[] condensed)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];
            }
            nums = condensed;
            return nums;
        }
    }
}