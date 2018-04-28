namespace IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var secondList = new List<string>();
            var command = string.Empty;

            for (int i = 0; ; i++)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                secondList.Add(command);
            }

            var currentNumber = string.Empty;
            char firstDigit = '\0';
            var convertStringToInt = 0;
            var convertCharToInt = 0;
            
            for (int i = 0; i < secondList.Count; i++)
            {
                currentNumber = secondList[i];
                firstDigit = currentNumber[0];
                convertCharToInt = firstDigit - '0';
                convertStringToInt = Convert.ToInt32(secondList[i]);
                numbers.Insert(convertCharToInt, convertStringToInt);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
