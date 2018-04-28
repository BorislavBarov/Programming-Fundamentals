namespace EqualSumAfterExtraction
{
    using System;
    using System.Linq;

    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sumNumbersOfFirstList = 0;
            var sumNumbersOfSecondList = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                }
            }

            foreach (var number in firstList)
            {
                sumNumbersOfFirstList += number;
            }

            foreach (var number in secondList)
            {
                sumNumbersOfSecondList += number;
            }

            if (sumNumbersOfFirstList == sumNumbersOfSecondList)
            {
                Console.WriteLine("Yes. Sum: " + sumNumbersOfFirstList);
            }
            else
            {
                Console.WriteLine("No. Diff: " + Math.Abs(sumNumbersOfFirstList - sumNumbersOfSecondList));
            }
        }
    }
}
