namespace FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (input != "end")
            {
                var tokens = input.Split();

                if (tokens[0] != "flatten")
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }

                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    var key = tokens[1];

                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                input = Console.ReadLine();
            }

            var orderedDictionary = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDictionary)
            {
                Console.WriteLine(entry.Key);
                    
                var orderedInnerDictionary = entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedValues = entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var sequence = 1;

                foreach (var innerEntry in orderedInnerDictionary)
                {
                    Console.WriteLine($"{sequence}. {innerEntry.Key} - {innerEntry.Value}");
                    sequence++;
                }

                foreach (var flattenedEntry in flattenedValues)
                {
                    Console.WriteLine($"{sequence}. {flattenedEntry.Key}");
                    sequence++;
                }
            }
        }
    }
}
