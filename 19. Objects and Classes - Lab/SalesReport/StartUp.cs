namespace SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var sales = ReadSale();

            var salesByTown = GetSales(sales);

            PrintSales(salesByTown);
        }

        private static void PrintSales(SortedDictionary<string, decimal> salesByTown)
        {
            foreach (var sale in salesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }

        public static SortedDictionary<string, decimal> GetSales(Sale[] sales)
        {
            var salesByTown = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown[sale.Town] = 0;
                }
                salesByTown[sale.Town] += sale.Profit;
            }

            return salesByTown;
        }

        public static Sale[] ReadSale()
        {
            int n = int.Parse(Console.ReadLine());          

            var sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                var sale = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                sales[i] = new Sale
                {
                    Town = sale[0],
                    Product = sale[1],
                    Price = decimal.Parse(sale[2]),
                    Quantity = decimal.Parse(sale[3])
                };
            }
            return sales;
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Profit
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}
