namespace RectanglePosition
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var input2 = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var rectangle1 = new Rectangle();
            var rectangle2 = new Rectangle();

            rectangle1.Left = input1[0];
            rectangle1.Top = input1[1];
            rectangle1.Width = input1[2];
            rectangle1.Height = input1[3];

            rectangle2.Left = input2[0];
            rectangle2.Top = input2[1];
            rectangle2.Width = input2[2];
            rectangle2.Height = input2[3];

            var isInside = IsInside(rectangle1, rectangle2);

            Console.WriteLine(isInside ? "Inside" : "Not inside");
        }

        public static bool IsInside(Rectangle rectangle1, Rectangle rectangle2)
        {
            var result = rectangle1.Left >= rectangle2.Left
                && rectangle1.Right <= rectangle2.Right
                && rectangle1.Top <= rectangle2.Top
                && rectangle1.Bottom <= rectangle2.Bottom ?
                true : false;

            return result;
        }
    }

    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right
        {
            get
            {
                return Left + Width;
            }

        }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
    }
}
