namespace HappinessIndex
{
    using System;
    using System.Text.RegularExpressions;

    public class HappinessIndex
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var happyRegex = new Regex(@":\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;");
            var sadRegex = new Regex(@":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|\];");

            double happyEmoticons = happyRegex.Matches(input).Count;
            double sadEmoticons = sadRegex.Matches(input).Count;
            double happinessIndex = happyEmoticons / sadEmoticons;

            if (happinessIndex >= 2)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :D");
                Console.WriteLine($"[Happy count: {happyEmoticons}, Sad count: {sadEmoticons}]");
            }
            else if (happinessIndex > 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :)");
                Console.WriteLine($"[Happy count: {happyEmoticons}, Sad count: {sadEmoticons}]");
            }
            else if (happinessIndex == 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :|");
                Console.WriteLine($"[Happy count: {happyEmoticons}, Sad count: {sadEmoticons}]");
            }
            else if (happinessIndex < 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :(");
                Console.WriteLine($"[Happy count: {happyEmoticons}, Sad count: {sadEmoticons}]");
            }
        }
    }
}
