namespace SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalSum = 0.00M;

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsules = long.Parse(Console.ReadLine());

                var year = date.Year;
                var month = date.Month;
                var daysInMonth = DateTime.DaysInMonth(year, month);

                var price = (decimal)(daysInMonth * capsules) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalSum += price;
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
