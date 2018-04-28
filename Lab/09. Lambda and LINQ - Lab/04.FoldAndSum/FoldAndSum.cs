namespace FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = nums.Length / 4;

            var leftPart = nums
                .Take(k)
                .Reverse()
                .ToArray();

            var rightPart = nums
                .Reverse()
                .Take(k)
                .ToArray();

            var rowOne = leftPart
                .Concat(rightPart)
                .ToArray();

            var rowTwo = nums
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var sum = rowOne
                .Select((x, index) => x + rowTwo[index])
                .ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
