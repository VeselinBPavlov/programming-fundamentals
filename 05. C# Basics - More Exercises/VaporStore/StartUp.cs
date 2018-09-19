namespace _2.Vapor_Store
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var currentBalance = decimal.Parse(Console.ReadLine());
            var totalMoney = currentBalance;

            var buyingOrder = Console.ReadLine();

            while (buyingOrder != "Game Time")
            {

                switch (buyingOrder)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            Console.WriteLine($"Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        if (currentBalance >= 15.99m)
                        {
                            currentBalance -= 15.99m;
                            Console.WriteLine($"Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (currentBalance >= 19.99m)
                        {
                            currentBalance -= 19.99m;
                            Console.WriteLine($"Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        if (currentBalance >= 59.99m)
                        {
                            currentBalance -= 59.99m;
                            Console.WriteLine($"Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch":
                        if (currentBalance >= 29.99m)
                        {
                            currentBalance -= 29.99m;
                            Console.WriteLine($"Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            Console.WriteLine($"Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                buyingOrder = Console.ReadLine();
            }

            var remainingMoney = totalMoney - currentBalance;
            Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
