namespace MonthPrinter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var month = int.Parse(Console.ReadLine());

            string mon = "";

            if (month <= 0 || month >= 13)
                Console.WriteLine("Error!");

            switch (month)
            {
                case 1: mon = "January"; break;
                case 2: mon = "February"; break;
                case 3: mon = "March"; break;
                case 4: mon = "April"; break;
                case 5: mon = "May"; break;
                case 6: mon = "June"; break;
                case 7: mon = "July"; break;
                case 8: mon = "August"; break;
                case 9: mon = "September"; break;
                case 10: mon = "Octomber"; break;
                case 11: mon = "November"; break;
                case 12: mon = "December"; break;
            }

            Console.WriteLine(mon);
        }
    }
}