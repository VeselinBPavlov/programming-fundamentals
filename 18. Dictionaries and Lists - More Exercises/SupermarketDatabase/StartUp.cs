namespace SupermarketDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var productData = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var prices = new Dictionary<string, decimal>();
            var quantities = new Dictionary<string, int>();
            var totalPrices = new Dictionary<string, decimal>();
            var grandTotal = 0.00M;

            while (productData[0] != "stocked")
            {
                var product = productData[0];
                var price = decimal.Parse(productData[1]);
                var quantity = int.Parse(productData[2]);

                if (prices.ContainsKey(product) == false)
                {
                    prices.Add(product, price);
                    quantities.Add(product, quantity);
                    totalPrices.Add(product, (decimal)price * quantity);
                }
                else
                {
                    prices[product] = price;
                    quantities[product] += quantity;
                    totalPrices[product] = (decimal)price * quantities[product];
                }

                productData = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }

            foreach (var product in totalPrices)
            {               
                grandTotal += product.Value;
                Console.WriteLine($"{product.Key}: ${prices[product.Key]:F2} * {quantities[product.Key]} = ${product.Value:F2}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");            
        }
    }
}
