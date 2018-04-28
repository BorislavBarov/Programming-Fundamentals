namespace TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class TearListInHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var leftHalf = new List<int>();
            var rightHalf = new List<int>();
            var result = new List<int>();
            var counter = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                leftHalf.Add(numbers[i]);
            }

            for (int i = numbers.Count / 2; i < numbers.Count; i++)
            {
                rightHalf.Add(numbers[i]);
            }

            foreach (char symbol in rightHalf)
            {
                var numberOne = symbol / 10;
                var numberTwo = symbol % 10;
                result.Add(numberOne);
                result.Add(numberTwo);
            }

            for (int i = 1; i < numbers.Count + (numbers.Count / 2); i = i + 3)
            {
                result.Insert(i, leftHalf[counter]);
                counter++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
