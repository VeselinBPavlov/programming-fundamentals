namespace TrainingHallEquipment
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            decimal sum = 0.00M;

            for (int i = 1; i <= numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                decimal itemCount = decimal.Parse(Console.ReadLine());

                if (itemCount == 1)
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                else
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");

                sum += (itemPrice * itemCount);
            }

            Console.WriteLine($"Subtotal: ${sum}");
            if (budget >= sum)
                Console.WriteLine("Money left: ${0:f2}", budget - sum);
            else
                Console.WriteLine("Not enough. We need ${0:f2} more.", sum - budget);
        }
    }
}
