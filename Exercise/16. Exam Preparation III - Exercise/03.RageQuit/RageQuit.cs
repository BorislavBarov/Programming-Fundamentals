namespace RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"(\D+)(\d+)");
            var matches = regex.Matches(input);
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var number = int.Parse(match.Groups[2].ToString());
                var symbols = match.Groups[1].ToString().ToUpper();

                for (int i = 0; i < number; i++)
                {
                    sb.Append(symbols);
                }
            }

            var uniqueSymbols = sb.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(sb.ToString());
        }
    }
}
