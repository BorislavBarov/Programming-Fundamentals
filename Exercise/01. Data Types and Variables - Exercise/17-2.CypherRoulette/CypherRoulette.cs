namespace CypherRoulette
{
    using System;

    public class CypherRoulette
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var line = string.Empty;

            var isAppendingToTheEnd = true;

            while (n > 0)
            {
                var previousLine = line;

                line = Console.ReadLine();

                if (line == previousLine)
                {
                    result = string.Empty;

                    if (line != "spin")
                    {
                        n--;
                    }

                    continue;
                }

                if (line == "spin")
                {
                    isAppendingToTheEnd = !isAppendingToTheEnd;
                    continue;
                }

                result = isAppendingToTheEnd ? result + line : line + result;
                n--;
            }

            Console.WriteLine(result);
        }
    }
}
