namespace PizzaIngredients
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var ingredients = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var allowableLength = int.Parse(Console.ReadLine());

            var counter = 0;
            var ingredientLength = 0;
            var addedIngredients = new string[ingredients.Length].ToArray();


            for (int i = 0; i < ingredients.Length && counter < 10; i++)
            {
                ingredientLength = ingredients[i].Length;
                
                if (allowableLength == ingredientLength)
                {                   
                    addedIngredients[counter] += ingredients[i];
                    counter++;
                    Console.WriteLine($"Adding {ingredients[i]}.");                  
                }
            }

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngredients.Take(counter))}.");
        }
    }
}
