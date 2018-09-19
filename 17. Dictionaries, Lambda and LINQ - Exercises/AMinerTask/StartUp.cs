namespace AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var resourseQuantity = new Dictionary<string, int>();

            while (input != "stop")
            {
                var resourse = input;
                var quantity = int.Parse(Console.ReadLine());

                if (!resourseQuantity.ContainsKey(resourse))
                {
                    resourseQuantity.Add(resourse, 0);
                }

                resourseQuantity[resourse] += quantity;

                input = Console.ReadLine();
            }

            foreach (var resourse in resourseQuantity)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }

        }
    }
}
