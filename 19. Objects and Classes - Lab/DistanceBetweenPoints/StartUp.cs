namespace DistanceBetweenPoints
{
    using System;
    using System.Linq;   

    public class StartUp
    {
        public static void Main()
        {
            var firstPoint = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var secondPoint = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var distance = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        public static double CalculateDistance(double[] firstPoint, double[] secondPoint)
        {
            var point1 = new Point();
            var point2 = new Point();
            point1.X = firstPoint[0];
            point1.Y = firstPoint[1];
            point2.X = secondPoint[0];
            point2.Y = secondPoint[1];

            var sideA = (point1.X - point2.X);
            var sideB = (point1.Y - point2.Y);
            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return sideC;
        }       
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}