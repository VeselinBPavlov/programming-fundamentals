namespace Snowballs
{
    using System;
    using System.Numerics;


    public class StartUp
    {
        public static void Main()
        {
            var snowballsCount = int.Parse(Console.ReadLine());

            var snowballSnowOutput = 0;
            var snowballTimeOutput = 0;
            var snowballQualityOutput = 0;
            BigInteger snowballValueOutput = -9999999999999;
            

            for (int i = 0; i < snowballsCount; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                var snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);               
              
                if (snowballValue > snowballValueOutput)
                {
                    snowballSnowOutput = snowballSnow;
                    snowballTimeOutput = snowballTime;
                    snowballQualityOutput = snowballQuality;
                    snowballValueOutput = snowballValue;
                }
            }

            Console.WriteLine($"{snowballSnowOutput} : {snowballTimeOutput} = {snowballValueOutput} ({snowballQualityOutput})");
        }
    }
}
