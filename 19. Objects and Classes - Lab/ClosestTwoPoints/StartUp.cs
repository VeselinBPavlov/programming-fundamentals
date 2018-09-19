namespace ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            
            var points = new List<double>();
            var firstPoint = new List<double>();
            var secondPoint = new List<double>();
            var closestCoordinates = new List<double>();
            var minDistance = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var coordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

                points.AddRange(coordinates);
            }

            for (int i = 0; i < points.Count; i += 2)
            {
                firstPoint.Clear();
                firstPoint.Add(points[i]);
                firstPoint.Add(points[i + 1]);

                for (int j = i + 2; j < points.Count; j += 2)
                {
                    secondPoint.Clear();
                    secondPoint.Add(points[j]);
                    secondPoint.Add(points[j + 1]);

                    var distance = CalculateDistance(firstPoint, secondPoint);
                    
                    if (distance < minDistance)
                    {
                        closestCoordinates.Clear();
                        minDistance = distance;
                        closestCoordinates.AddRange(firstPoint);
                        closestCoordinates.AddRange(secondPoint);
                    }                    
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({closestCoordinates[0]}, {closestCoordinates[1]})");
            Console.WriteLine($"({closestCoordinates[2]}, {closestCoordinates[3]})");
        }

        public static double CalculateDistance(List<double> firstPoint, List<double> secondPoint)
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
