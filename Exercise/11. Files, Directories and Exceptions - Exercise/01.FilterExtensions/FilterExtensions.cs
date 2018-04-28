namespace FilterExtensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FilterExtensions
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var inputFiles = Directory.GetFiles("input");
            var files = new List<string>();

            foreach (var file in inputFiles)
            {
                if (file.Contains(input))
                {
                    var splitFile = file.Split('\\');
                    files.Add(splitFile[1]);
                }
            }

            File.WriteAllLines("Output.txt", files);
        }
    }
}
