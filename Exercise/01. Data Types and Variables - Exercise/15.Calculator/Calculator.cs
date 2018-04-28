namespace Calculator
{
    using System;

    public class Calculator
    {
        public static void Main()
        {
            var firstOperand = int.Parse(Console.ReadLine());
            char operatorCalculation = char.Parse(Console.ReadLine());
            var secondOperand = int.Parse(Console.ReadLine());

            switch (operatorCalculation)
            {
                case '+':
                    Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
                    break;

                case '-':
                    Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                    break;

                case '*':
                    Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                    break;

                case '/':
                    Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                    break;
            }
        }
    }
}