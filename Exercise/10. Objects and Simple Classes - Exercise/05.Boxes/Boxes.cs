namespace Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Boxes
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var listOfBoxes = new List<Box>();

            while (input != "end")
            {
                var inputParts = input.Split(new[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                var box = new Box
                {
                    UpperLeft = new Point
                    {
                        X = inputParts[0],
                        Y = inputParts[1]
                    },

                    UpperRight = new Point
                    {
                        X = inputParts[2],
                        Y = inputParts[3]
                    },

                    BottomLeft = new Point
                    {
                        X = inputParts[4],
                        Y = inputParts[5]
                    },

                    BottomRight = new Point
                    {
                        X = inputParts[6],
                        Y = inputParts[7]
                    }
                };

                listOfBoxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var box in listOfBoxes)
            {
                var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);
                var perimeter = Box.CalculatePerimeter((int)width, (int)height);
                var area = Box.CalculateArea((int)width, (int)height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
        }
    }
}
