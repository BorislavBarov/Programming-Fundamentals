namespace FolderSize
{
    using System;
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");

            var total = 0L;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                total += fileInfo.Length;
            }

            var totalMB = (total / 1024.0) / 1024.0;

            File.WriteAllText("Output.txt", totalMB.ToString());
        }
    }
}
