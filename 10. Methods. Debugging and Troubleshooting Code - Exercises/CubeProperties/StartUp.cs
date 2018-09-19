namespace CubeProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double sideCube  = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":   GetFaceDiagonalCube(sideCube);  break;
                case "space":  GetSpaceDiagonalCube(sideCube); break;
                case "volume": GetVolumeCube(sideCube);        break;
                case "area":   GetAreaCube(sideCube);          break;
            }
        }

        public static void GetFaceDiagonalCube(double sideCube)
        {
            double faceDiagonal = Math.Sqrt(2 * sideCube * sideCube);
            Console.WriteLine($"{faceDiagonal:f2}");
        }

        public static void GetSpaceDiagonalCube(double sideCube)
        {
            double spaceDiagonal = Math.Sqrt(3 * sideCube * sideCube);
            Console.WriteLine($"{spaceDiagonal:f2}");
        }

        public static void GetVolumeCube(double sideCube)
        {
            double volumeCube = Math.Pow(sideCube, 3);
            Console.WriteLine($"{volumeCube:f2}");
        }

        public static void GetAreaCube(double sideCube)
        {
            double areaCube = (6 * sideCube * sideCube);
            Console.WriteLine($"{areaCube:f2}");
        }
    }
}
