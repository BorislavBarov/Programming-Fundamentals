namespace StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstResult = new List<int>();
            var secondResult = new List<int>();
            var result = new List<int>();

            int min = int.MaxValue;

            foreach (var number in firstList)
            {
                var numberCount = Math.Abs(number);
                var stringLenght = numberCount.ToString().Length;
                min = Math.Min(min, stringLenght);
            }

            foreach (var number in secondList)
            {
                var numberCount = Math.Abs(number);
                var stringLenght = numberCount.ToString().Length;
                min = Math.Min(min, stringLenght);
            }

            for (int i = 0; i < firstList.Count; i++)
            {
                if (firstList[i] < 0 && firstList[i].ToString().Length > min + 1)
                {
                    firstList.Remove(firstList[i]);
                    i--;
                }
                else if (firstList[i] > 0 && firstList[i].ToString().Length > min)
                {
                    firstList.Remove(firstList[i]);
                    i--;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (secondList[i] < 0 && secondList[i].ToString().Length > min + 1)
                {
                    secondList.Remove(secondList[i]);
                    i--;
                }
                else if (secondList[i] > 0 && secondList[i].ToString().Length > min)
                {
                    secondList.Remove(secondList[i]);
                    i--;
                }
            }

            for (int i = 0; ; i++)
            {
                if (result.Count == firstList.Count + secondList.Count)
                {
                    break;
                }

                if (secondList.Count > i)
                {
                result.Add(secondList[i]);
                }

                if (firstList.Count > i)
                {
                result.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}