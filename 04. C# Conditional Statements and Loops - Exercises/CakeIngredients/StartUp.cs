namespace CakeIngredients
{
    using System;

    public class StartUp
    {
       public static void Main()
        {
            for (int i = 0; i <= 20; i++)
            {
                string ingredientName = Console.ReadLine();

                if (ingredientName == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    return;
                }
                else
                Console.WriteLine($"Adding ingredient {ingredientName}.");
            }
        }
    }
}
