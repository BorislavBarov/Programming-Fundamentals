namespace RefactorSpecialNumbers
{
    using System;

    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= n; currentNumber++)
            {
                int sumOfDigit = 0;
                var number = currentNumber;

                while (number > 0)
                {
                    sumOfDigit += number % 10;
                    number = number / 10;
                }

                bool result = (sumOfDigit == 5) || (sumOfDigit == 7) || (sumOfDigit == 11);
                Console.WriteLine($"{currentNumber} -> {result}");
            }
        }
    }
}
