namespace DictRefAdvanced
{
    using System;
    using System.Collections.Generic;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var number = 0;
                var numbers = new List<int>();

                if (!result.ContainsKey(name))
                {
                    result[name] = new List<int>();
                }

                foreach (var item in tokens)
                {
                    if (int.TryParse(item, out number))
                    {
                        result[name].Add(number);
                    }
                }

                if (result.ContainsKey(tokens[1]))
                {
                    result[name] = new List<int>(result[tokens[1]]);
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                if (item.Value.Count != 0)
                {
                    Console.WriteLine("{0} === {1}", item.Key, string.Join(", ", item.Value));
                }
            }
        }
    }
}