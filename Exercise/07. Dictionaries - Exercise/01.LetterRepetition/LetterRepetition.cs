namespace LetterRepetition
{
    using System;
    using System.Collections.Generic;

    public class LetterRepetition
    {
        public static void Main()
        {
            var str = Console.ReadLine();

            var letters = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!letters.ContainsKey(str[i]))
                {
                    letters[str[i]] = 0;
                }

                letters[str[i]]++;
            }
            
            foreach (var letter in letters)
            {
                Console.WriteLine(letter.Key + " -> " + letter.Value);
            }
        }
    }
}
