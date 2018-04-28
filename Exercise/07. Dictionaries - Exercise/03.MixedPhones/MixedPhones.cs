namespace MixedPhones
{
    using System;
    using System.Collections.Generic;

    public class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new SortedDictionary<string, long>();

            while (input != "Over")
            {
                var splitInput = input.Split();
                var firstElement = splitInput[0];
                var lastElement = splitInput[splitInput.Length - 1];

                var number = 0L;

                if (long.TryParse(lastElement, out number))
                {
                    result[firstElement] = number;
                }
                else if (long.TryParse(firstElement, out number))
                {
                    result[lastElement] = number;
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
