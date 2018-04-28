namespace InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var inserted = false;
                var currentElement = numbers[i];

                for (int i2 = 0; i2 < result.Count; i2++)
                {
                    var currentListElement = result[i2];

                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        result.Insert(Math.Max(0, i2), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    result.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}