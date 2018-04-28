namespace Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            var perimeter = (2 * width) + (2 * height);
            return perimeter;
        }

        public static int CalculateArea(int width, int height)
        {
            var area = width * height;
            return area;
        }
    }
}
