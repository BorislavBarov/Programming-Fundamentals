namespace CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var counts = new SortedDictionary<double, int>();

            foreach (var num in nums)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;
                }

                counts[num]++;
            }

            foreach (var element in counts)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
