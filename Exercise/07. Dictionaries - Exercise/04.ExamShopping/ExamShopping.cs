namespace ExamShopping
{
    using System;
    using System.Collections.Generic;

    public class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (input != "exam time")
            {
                var splitInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = string.Empty;
                var product = string.Empty;
                var quantity = 0;

                if (input != "shopping time")
                {
                    command = splitInput[0];
                    product = splitInput[1];
                    quantity = int.Parse(splitInput[2]);
                }

                if (command == "stock")
                {
                    if (!result.ContainsKey(product))
                    {
                        result[product] = 0;
                    }

                    result[product] += quantity;
                }
                else if (command == "buy")
                {
                    if (!result.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");
                    }
                    else if (result[product] <= 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        result[product] -= quantity;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
