namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt")
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();
            
            var textWords = File.ReadAllText("text.txt")
                .Split(new[] { ' ', ',', '.', '-', '!', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();

            var result = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var currentWordCount = 0;

                for (int j = 0; j < textWords.Length; j++)
                {
                    if (currentWord == textWords[j])
                    {
                        currentWordCount++;
                        result[currentWord] = currentWordCount;
                    }
                }
            }

            var sortedResult = result
                .OrderByDescending(x => x.Value)
                .Select(x => $"{x.Key} - {x.Value}")
                .ToArray();

            File.WriteAllLines("Output.txt", sortedResult);
        }
    }
}
