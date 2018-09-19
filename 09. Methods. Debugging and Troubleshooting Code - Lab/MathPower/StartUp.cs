namespace MathPower
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double grade  = double.Parse(Console.ReadLine());
            double result = Gradation(number, grade);
            Console.WriteLine(result);
        }

        static double Gradation(double number, double grade)
        {
            return Math.Pow(number, grade);
        }
    }
}