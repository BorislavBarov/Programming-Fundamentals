namespace LargestNElements
{
    using System;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < number; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}