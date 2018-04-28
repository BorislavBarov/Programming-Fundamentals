namespace FlipListSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstNumber = numbers[0];
            var lastNumber = numbers[numbers.Count - 1];

            var result = new List<int>();

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                result.Add(numbers[i]);
            }

            if (numbers.Count <= 3)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine();
            }
            else
            {
                result.Reverse();
                result.Insert(0, firstNumber);
                result.Add(lastNumber);
                
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}