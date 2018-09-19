namespace CharacterStats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', (maximumHealth - currentHealth)));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', (maximumEnergy - currentEnergy)));
        }
    }
}
