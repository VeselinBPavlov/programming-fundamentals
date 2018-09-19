namespace PadawanEquipment
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var ammountMoney = decimal.Parse(Console.ReadLine());
            var studentsCount = decimal.Parse(Console.ReadLine());
            var lightSabersPrice = decimal.Parse(Console.ReadLine());
            var robesPrice = decimal.Parse(Console.ReadLine());
            var beltsPrice = decimal.Parse(Console.ReadLine());

            var neededSabers = Math.Ceiling(studentsCount + studentsCount * 0.1M);
            var freeBelts = Math.Floor(studentsCount / 6);

            var totalSum = (lightSabersPrice * (neededSabers)) + (robesPrice * studentsCount) + (beltsPrice * (studentsCount - freeBelts));

            if (totalSum <= ammountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalSum - ammountMoney:f2}lv more.");
            }
        }
    }
}
