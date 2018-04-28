namespace SortArrayUsingBubbleSort
{
    using System;
    using System.Linq;

    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
