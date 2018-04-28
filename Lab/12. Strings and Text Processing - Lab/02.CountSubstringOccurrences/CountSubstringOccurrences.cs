namespace CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var textPart = Console.ReadLine().ToLower();

            var index = 0;
            var counter = 0;

            while (true)
            {
                var found = text.IndexOf(textPart, index);

                if (found >= 0)
                {
                    counter++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
