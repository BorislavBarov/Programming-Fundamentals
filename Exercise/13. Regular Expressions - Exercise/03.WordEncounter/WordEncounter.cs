namespace WordEncounter
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class WordEncounter
    {
        public static void Main()
        {
            var filter = Console.ReadLine();
            var input = Console.ReadLine();

            var result = new List<string>();

            while (input != "end")
            {
                var isMatch = Regex.IsMatch(input, @"(?<!.)[A-Z](.*)[.!?](?!.)");

                if (isMatch)
                {
                    var words = Regex.Matches(input, @"(\w+)");

                    foreach (Match word in words)
                    {
                        var symbol = filter[0];
                        var count = int.Parse(filter[1].ToString());
                        var currentWord = word.Groups[0].Value;
                        var counter = 0;

                        foreach (var character in currentWord)
                        {
                            if (character == symbol)
                            {
                                counter++;
                            }
                        }

                        if (count <= counter)
                        {
                            result.Add(currentWord);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}