namespace CypherRoulette
{
    using System;

    public class CypherRoulette
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string lastString = string.Empty;
            string cypherString = string.Empty;
            var currentIndex = 0;
            var counter = 0;

            for (int i = 1; i <= n; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString != "spin")
                {
                    if (counter == 1)
                    {
                        cypherString = currentString + cypherString;
                        currentIndex = i;
                    }
                    else if (currentIndex + 1 == i)
                    {
                        cypherString = cypherString + currentString;
                    }
                    else
                    {
                        cypherString = cypherString + currentString;
                    }
                }

                if (currentString == "spin")
                {
                    counter++;
                    i--;
                }

                if (lastString == currentString)
                {
                    lastString = string.Empty;
                    cypherString = string.Empty;
                }

                lastString = currentString;
            }

            Console.WriteLine(cypherString);
        }
    }
}