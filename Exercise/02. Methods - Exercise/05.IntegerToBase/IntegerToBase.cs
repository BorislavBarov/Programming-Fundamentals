namespace IntegerToBase
{
    using System;

    public class IntegerToBase
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var result = NumberToBase(number, toBase);
            Console.WriteLine(result);
        }

        public static string NumberToBase(int number, int toBase)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var currentResult = number % toBase;
                result = currentResult + result;
                number /= toBase;
            }

            return result;
        }
    }
}