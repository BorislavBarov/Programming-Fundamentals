namespace DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();
            result.Add(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (result.Contains(numbers[i]))
                {
                    continue;
                }
                else
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
