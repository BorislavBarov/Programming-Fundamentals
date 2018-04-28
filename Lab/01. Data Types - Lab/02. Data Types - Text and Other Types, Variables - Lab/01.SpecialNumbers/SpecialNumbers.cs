namespace SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= n; currentNumber++)
            {
                var sum = 0;

                foreach (var symbol in currentNumber.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;
                }

                bool result = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{currentNumber} -> {result}");
            }
        }
    }
}
