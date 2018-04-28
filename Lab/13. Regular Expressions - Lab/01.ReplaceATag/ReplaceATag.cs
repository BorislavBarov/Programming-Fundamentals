namespace ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            
            var pattern = @"<a.?href=(.+?)>(.+?)<\/a>";
            var regex = new Regex(pattern);
            var replacement = "[URL href=$1]$2[/URL]";

            while (text != "end")
            {
                var result = regex.Replace(text, replacement);
                Console.WriteLine(result);
                text = Console.ReadLine();
            }
        }
    }
}
