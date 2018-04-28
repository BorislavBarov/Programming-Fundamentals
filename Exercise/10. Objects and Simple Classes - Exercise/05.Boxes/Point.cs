namespace Boxes
{
    using System;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static double CalculateDistance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            var sqrt = Math.Sqrt(squareX + squareY);

            return sqrt;
        }
    }
}
