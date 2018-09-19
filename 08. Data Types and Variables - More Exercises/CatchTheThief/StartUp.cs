namespace CatchTheThief
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string integerType = Console.ReadLine();
            long countIDs = long.Parse(Console.ReadLine());

            long thiefID = long.MinValue;

            for (int i = 0; i < countIDs; i++)
            {
                long numberID = long.Parse(Console.ReadLine());

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
            Console.WriteLine(thiefID);
        }
    }
}
