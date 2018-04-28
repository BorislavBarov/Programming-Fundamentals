namespace Palindromes
{
    using System;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var reversedText = new List<string>();

            foreach (var word in text)
            {
                string reverse = string.Empty;

                for (int i = word.Length - 1; i > -1; i--)
                {
                    reverse += word[i];
                }

                reversedText.Add(reverse);
            }

            var result = new SortedSet<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == reversedText[i])
                {
                    result.Add(text[i]);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
