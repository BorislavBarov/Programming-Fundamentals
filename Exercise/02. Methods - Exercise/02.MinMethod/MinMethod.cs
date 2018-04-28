namespace MinMethod
{
    using System;

    public class MinMethod
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(firstNumber, secondNumber, thirdNumber));
        }

        public static int GetMin(int firstNumber, int secondNumber, int thirdNumber)
        {
            var result = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);
            return result;
        }
    }
}