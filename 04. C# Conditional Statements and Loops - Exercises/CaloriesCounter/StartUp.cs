namespace CaloriesCounter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int caloriesCounter = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredientName = Console.ReadLine().ToLower();
                if (ingredientName == "cheese")
                    caloriesCounter += 500;
                if (ingredientName == "tomato sauce")
                    caloriesCounter += 150;
                if (ingredientName == "salami")
                    caloriesCounter += 600;
                if (ingredientName == "pepper")
                    caloriesCounter += 50;
            }

            Console.WriteLine($"Total calories: {caloriesCounter}");
        }
    }
}
