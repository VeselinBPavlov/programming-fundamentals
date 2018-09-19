namespace EmailMe
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var email = Console.ReadLine().Split('@').ToArray();

            var leftSide = email[0].ToCharArray().Select(x => Convert.ToInt32(x)).ToList().Sum();
            var rightSide = email[1].ToCharArray().Select(x => Convert.ToInt32(x)).ToList().Sum();
            var result = leftSide - rightSide;

            Console.WriteLine(result >= 0 ? "Call her!" : "She is not the one.");
        }
    }
}
