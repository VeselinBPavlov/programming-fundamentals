namespace BoatSimulator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            int pointsFirstBoat = 0;
            int pointsSecondBoat = 0;

            for (int i = 1; i <= num; i++)
            {
                string word = Console.ReadLine();

                if (word == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                }
                else
                {
                    if (i % 2 == 1)                    
                        pointsFirstBoat += word.Length;                    
                    else                    
                        pointsSecondBoat += word.Length;                    
                }
                if (pointsFirstBoat >= 50 || pointsSecondBoat >= 50)
                    break;
            }
            if (pointsFirstBoat > pointsSecondBoat)
                Console.WriteLine(firstBoat);
            else
                Console.WriteLine(secondBoat);
        }
    }
}
