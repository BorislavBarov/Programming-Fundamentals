namespace DictRef
{
    using System;
    using System.Collections.Generic;

    public class DictRef
    {
        public static void Main()
        {
            var result = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var splitInput = input.Split();
                var firstElement = splitInput[0];
                var lastElement = splitInput[splitInput.Length - 1];

                var number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    result[firstElement] = number;
                }
                else if (result.ContainsKey(lastElement))
                {
                    var value = result[lastElement];
                    result[firstElement] = value;
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " === " + item.Value);
            }
        }
    }
}
