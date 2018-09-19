namespace UpgradedMatcher
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var products = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToArray();
            var quantity = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var price = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            while (input[0] != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (input[0] == products[i])
                    {
                        var quantityNeed = long.Parse(input[1]);

                        try
                        {
                            if (quantityNeed > quantity[i])
                            {
                                Console.WriteLine($"We do not have enough {products[i]}");
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                            continue;
                        }

                        var costs = (decimal)quantityNeed * price[i];
                        quantity[i] -= quantityNeed;
                        Console.WriteLine($"{products[i]} x {quantityNeed} costs {costs:f2}");
                    }
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }
    }
}