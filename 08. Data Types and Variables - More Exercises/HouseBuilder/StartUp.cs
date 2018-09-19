namespace HouseBuilder
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long firstMaterial = long.Parse(Console.ReadLine());
            long secondMaterial = long.Parse(Console.ReadLine());

            if (firstMaterial < secondMaterial)
            {
                firstMaterial *= 4;
                secondMaterial *= 10;
            }
            else
            {
                firstMaterial *= 10;
                secondMaterial *= 4;
            }
            Console.WriteLine(firstMaterial + secondMaterial);
        }
    }
}
