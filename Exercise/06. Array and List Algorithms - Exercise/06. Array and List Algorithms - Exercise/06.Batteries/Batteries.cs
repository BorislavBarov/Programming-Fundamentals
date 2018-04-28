namespace Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Batteries
    {
        public static void Main()
        {
            var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var usePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var testHour = double.Parse(Console.ReadLine());

            var result = new List<double>();
            var percentage = 0.0;

            for (var i = 0; i < capacity.Count; i++)
            {
                result.Add(capacity[i] - (usePerHour[i] * testHour));
            }

            for (var i = 0; i < result.Count; i++)
            {
                if (result[i] > 0)
                {
                    percentage = (result[i] / capacity[i]) * 100;
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", (i + 1), result[i], percentage);
                }
                else
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", (i + 1), Math.Ceiling(capacity[i] / usePerHour[i]));
                }
            }
        }
    }
}
