namespace DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, string>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                dictionary[tokens[0]] = tokens[1];

                input = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var unchangedValues = dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var changedValues = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var item in unchangedValues)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }

            foreach (var item in changedValues)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
