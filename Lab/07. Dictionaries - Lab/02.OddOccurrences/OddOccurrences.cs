namespace OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToArray();

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }

                result[word]++;
            }

            var oddNumberWords = new List<string>();

            foreach (var item in result)
            {
                if (item.Value % 2 != 0)
                {
                    oddNumberWords.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumberWords));
        }
    }
}
