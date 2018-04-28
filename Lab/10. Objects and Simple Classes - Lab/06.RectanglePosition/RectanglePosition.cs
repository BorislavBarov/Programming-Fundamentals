namespace RectanglePosition
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var result = firstRectangle.IsInside(secondRectangle);
            var printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);
        }

        public static Rectangle ReadRectangle()
        {
            var rectangleParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}
