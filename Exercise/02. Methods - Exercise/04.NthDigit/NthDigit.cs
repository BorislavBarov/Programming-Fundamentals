namespace NthDigit
{
    using System;

    public class NthDigit
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var digitAtIndex = FindNthDigit(number, index);
            Console.WriteLine(digitAtIndex);
        }

        public static int FindNthDigit(long number, int index)
        {
            var currentIndex = 1;

            while (number > 0)
            {
                if (currentIndex == index)
                {
                    return (int)(number % 10);
                }

                currentIndex++;
                number /= 10;
            }

            return (int)(number % 10);
        }
    }
}