namespace CountWorkingDays
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var workingDays = 0;            

            var hollydays = new DateTime[] 
            {
                new DateTime(2000, 01, 01), new DateTime(2000, 03, 03), new DateTime(2000, 05, 01), new DateTime(2000, 05, 06),
                new DateTime(2000, 05, 24), new DateTime(2000, 09, 06), new DateTime(2000, 09, 22), new DateTime(2000, 11, 01),
                new DateTime(2000, 12, 24), new DateTime(2000, 12, 25),  new DateTime(2000, 12, 26)
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var isHolliday = false;

                foreach (var holliday in hollydays)
                {
                    if (i.Day == holliday.Day && i.Month == holliday.Month)
                    {
                        isHolliday = true;
                        break;
                    }                    
                }

                if (!isHolliday && i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
