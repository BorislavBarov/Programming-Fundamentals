namespace StringRepeater
{
    using System;

    public class StringRepeater
    {
        public static void Main()
        {
            string randomString = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(randomString, count));
        }

        public static string RepeatString(string randomString, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += randomString;
            }

            return repeatedString;
        }
    }
}