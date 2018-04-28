namespace Last3ConsecutiveEqualStrings
{
    using System;

    public class Last3ConsecutiveEqualStrings
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            
            var lastThreeWord = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                if (i + 2 < words.Length && words[i] == words[i + 1] && words[i + 1] == words[i + 2])
                {
                    lastThreeWord = words[i] + " " + words[i + 1] + " " + words[i + 2];
                }
            }

            Console.WriteLine(lastThreeWord);
        }
    }
}