namespace HTMLContents
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class HTMLContents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var title = string.Empty;
            var bodyParts = new List<string>();

            while (input != "exit")
            {
                var inputParts = input.Split(' ');
                var tag = inputParts[0];
                var content = inputParts[1];

                if (tag == "title")
                {
                    title = content;
                }
                else
                {
                    bodyParts.Add($"\t<{tag}>{content}</{tag}>");
                }

                input = Console.ReadLine();
            }

            var result = new StringBuilder();

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");
            result.AppendLine($"\t<title>{title}</title>");
            result.AppendLine("</head>");
            result.AppendLine("<body>");
            result.AppendLine(string.Join(Environment.NewLine, bodyParts));
            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("index.html", result.ToString().Trim());
        }
    }
}
