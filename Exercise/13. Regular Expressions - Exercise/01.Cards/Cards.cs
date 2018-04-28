namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Cards
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var reges = new Regex("([1]?[0-9JQKA])([SHDC])");
            var matches = reges.Matches(input);
            var cards = new List<string>();

            foreach (Match card in matches)
            {
                var power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                cards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
