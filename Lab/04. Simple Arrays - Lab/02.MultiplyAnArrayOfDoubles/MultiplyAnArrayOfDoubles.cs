namespace MultiplyAnArrayOfDoubles
{
    using System;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
                Console.Write(numbers[i] + " ");
            }
        }
    }
}