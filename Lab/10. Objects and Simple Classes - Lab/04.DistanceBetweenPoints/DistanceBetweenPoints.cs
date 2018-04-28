namespace DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var firstPoint = new Point();
            firstPoint.X = firstPointParts[0];
            firstPoint.Y = firstPointParts[1];

            var secondPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var secondPoint = new Point();
            secondPoint.X = secondPointParts[0];
            secondPoint.Y = secondPointParts[1];

            var result = Distance(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");
        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            var sqrt = Math.Sqrt(squareX + squareY);

            return sqrt;
        }
    }
}
