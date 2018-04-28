namespace Extremums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Extremums
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = RotateElement(list[i], command);
            }

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(list.Sum());
        }

        private static int RotateElement(int number, string command)
        {
            var numberToList = new List<int>();
            var numberToString = number.ToString();

            foreach (var digit in numberToString)
            {
                numberToList.Add(int.Parse(digit.ToString()));
            }

            for (int i = 0; i < numberToList.Count; i++)
            {
                var firstDigit = numberToList[0];
                for (int k = 0; k < numberToList.Count - 1; k++)
                {
                    numberToList[k] = numberToList[k + 1];
                }

                numberToList[numberToList.Count - 1] = firstDigit;

                var currentNumber = int.Parse(string.Join("", numberToList));

                if (currentNumber > number && command.Equals("Max"))
                {
                    number = currentNumber;
                }
                else if (currentNumber < number && command.Equals("Min"))
                {
                    number = currentNumber;
                }
            }

            return number;
        }
    }
}
