namespace SentenceTheThief
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string integerType = Console.ReadLine();
            int receiveIDs = int.Parse(Console.ReadLine());

            decimal thiefID = decimal.MinValue;
            decimal years = 0.00M;

            for (int i = 0; i < receiveIDs; i++)
            {
                decimal numberID = decimal.Parse(Console.ReadLine());

                if (integerType == "sbyte")
                {
                    if ((sbyte.MinValue <= numberID) && (numberID <= sbyte.MaxValue))
                    {
                        if (numberID > thiefID)
                            thiefID = numberID;
                    }
                }

                if (integerType == "int")
                {
                    if ((int.MinValue <= numberID) && (numberID <= int.MaxValue))
                    {
                        if (numberID > thiefID)
                            thiefID = numberID;
                    }
                }

                if (integerType == "long")
                {
                    if ((long.MinValue <= numberID) && (numberID <= long.MaxValue))
                    {
                        if (numberID > thiefID)
                            thiefID = numberID;
                    }
                }
            }
            if (thiefID < 0)
            {
                years = (thiefID / -128M);
                years = Math.Round(years, 2);
            }
            else
            {
                years = thiefID / 127;
            }

            years = Math.Ceiling(years);

            if (years == 1)
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to 1 year");
            else
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {years} years");
        }
    }
}
