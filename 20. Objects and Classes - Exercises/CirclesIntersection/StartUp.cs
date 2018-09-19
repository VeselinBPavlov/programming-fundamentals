namespace CirclesIntersection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var input2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var circle1 = new Circle()
            { Center = GetPoint(input1[0], input1[1]), Radius = input1[2] };
            var circle2 = new Circle()
            { Center = GetPoint(input2[0], input2[1]), Radius = input2[2] };

            bool areIntercest = Intercest(circle1, circle2);

            Console.WriteLine(areIntercest ? "Yes" : "No");
        }

        static Point GetPoint(double v1, double v2)
        {
            return new Point
            { X = v1, Y = v2};
        }

        public static double DistanceBetweenCenters(Circle circle1, Circle circle2)
        {
            var sideA = circle1.Center.X - circle2.Center.X;
            var sideB = circle1.Center.Y - circle2.Center.Y;
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }

        public static bool Intercest(Circle circle1, Circle circle2)
        {
            var distance = DistanceBetweenCenters(circle1, circle2);
            var areIntercest = false;

            if (distance <= circle1.Radius + circle2.Radius)
                areIntercest = true;

            return areIntercest;
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }        
    }
}
