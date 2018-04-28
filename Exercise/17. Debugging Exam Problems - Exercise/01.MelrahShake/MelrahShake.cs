namespace MelrahShake
{
    using System;
    using System.Text.RegularExpressions;

    public class MelrahShake
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var inputPattern = Console.ReadLine();

            var regex = new Regex(Regex.Escape(inputPattern));
            var matches = regex.Matches(inputString);

            while (true)
            {
                if (matches.Count >= 2 && inputPattern.Length > 0)
                {
                    var startIndex = inputString.IndexOf(inputPattern);
                    var lastIndex = inputString.LastIndexOf(inputPattern);

                    inputString = inputString.Remove(lastIndex, inputPattern.Length);
                    inputString = inputString.Remove(startIndex, inputPattern.Length);

                    inputPattern = inputPattern.Remove(inputPattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                regex = new Regex(Regex.Escape(inputPattern));
                matches = regex.Matches(inputString);
            }

            Console.WriteLine(inputString);
        }
    }
}
