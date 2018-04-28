namespace TextFilter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            var result = string.Empty;

            foreach (var word in bannedWords)
            {
                result = text.Replace(word, new string('*', word.Length));
                text = result;
            }

            Console.WriteLine(result);
        }
    }
}
