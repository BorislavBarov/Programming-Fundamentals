namespace MultiplyEvensByOdds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }

        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdss = GetSumOfOddDigits(n);

            return sumEvens * sumOdss;
        }

        public static int GetSumOfOddDigits(int n)
        {
            var sum = 0;

            while (Math.Abs(n) > 0)
            {
                var lastDigits = n % 10;

                if (lastDigits % 2 != 0)
                {
                    sum += lastDigits;
                }

                n /= 10;
            }

            return sum;
        }

        public static int GetSumOfEvenDigits(int n)
        {
            var sum = 0;

            while (Math.Abs(n) > 0)
            {
                var lastDigits = n % 10;

                if (lastDigits % 2 == 0)
                {
                    sum += lastDigits;
                }

                n /= 10;
            }

            return sum;
        }
    }
}