namespace CirclePerimeter
{
    using System;

    public class CirclePerimeter
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", 2 * Math.PI * radius);
        }
    }
}