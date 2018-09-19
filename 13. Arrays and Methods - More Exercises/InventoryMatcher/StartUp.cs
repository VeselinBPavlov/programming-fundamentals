namespace InventoryMatcher
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
                .ToArray();
            var costs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var product = Console.ReadLine();

            while (product != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (product == products[i])
                    {
                        Console.WriteLine($"{products[i]} costs: {costs[i]}; Available quantity: {quantity[i]}");
                    }
                }

                product = Console.ReadLine();
            }
        }
    }
}