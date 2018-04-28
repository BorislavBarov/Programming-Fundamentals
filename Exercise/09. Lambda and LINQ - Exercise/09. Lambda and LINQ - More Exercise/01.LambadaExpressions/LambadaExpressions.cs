namespace LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (input != "lambada")
            {
                var tokens = input.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] != "dance")
                {
                    var selector = tokens[0];
                    var selectorObject = tokens[1];
                    var property = tokens[2];

                    if (!dictionary.ContainsKey(selector))
                    {
                        dictionary[selector] = new Dictionary<string, string>();
                    }

                    dictionary[selector][selectorObject] = property;
                }
                else
                {
                    dictionary = dictionary
                        .ToDictionary(x => x.Key, x => x.Value
                        .ToDictionary(y => y.Key, y => y.Key + "." + y.Value));
                }

                input = Console.ReadLine();
            }

            foreach (var selector in dictionary)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
