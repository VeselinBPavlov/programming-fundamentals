namespace DNASequences
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string firstSign = "";
            string secondSign = "";
            string thirdSign = "";           
            string firstLast = "";

            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                    firstSign = "A";
                if (i == 2)
                    firstSign = "C";
                if (i == 3)
                    firstSign = "G";
                if (i == 4)
                    firstSign = "T";
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1)
                        secondSign = "A";
                    if (j == 2)
                        secondSign = "C";
                    if (j == 3)
                        secondSign = "G";
                    if (j == 4)
                        secondSign = "T";
                    for (int k = 1; k <= 4; k++)
                    {
                        if (k == 1)
                            thirdSign = "A";
                        if (k == 2)
                            thirdSign = "C";
                        if (k == 3)
                            thirdSign = "G";
                        if (k == 4)
                            thirdSign = "T";

                        if ((i + j + k) >= n)
                            firstLast = "O";
                        else
                            firstLast = "X";

                        Console.Write($"{firstLast}{firstSign}{secondSign}{thirdSign}{firstLast} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
