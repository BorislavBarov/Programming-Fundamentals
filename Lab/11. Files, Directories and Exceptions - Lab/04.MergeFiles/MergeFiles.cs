namespace MergeFiles
{
    using System;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            var firstFile = File.ReadAllText("FileOne.txt").Split('\r', '\n');
            var secondFile = File.ReadAllText("FileTwo.txt").Split('\r', '\n');
            
            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("Output.txt", firstFile[i] + "\r\n" + secondFile[i]);
            }
        }
    }
}