namespace TrickyStrings
{
    using System;

    public class TrickyStrings
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 1; i < n; i++)
            { 
                currentString = Console.ReadLine();
                result += currentString;
                result += delimiter;
            }

            currentString = Console.ReadLine();

            result += currentString;

            Console.WriteLine(result);
        }
    }
}