namespace ReDirectory
{
    using System;
    using System.IO;

    public class ReDirectory
    {
        public static void Main()
        {
            var inputFiles = Directory.GetFiles("input");
            Directory.CreateDirectory("output");
            Directory.CreateDirectory("output/pngs");
            Directory.CreateDirectory("output/tests");
            Directory.CreateDirectory("output/txts");

            foreach (var path in inputFiles)
            {
                var file = path.Split('\\')[1];

                if (file.Contains("png"))
                {
                    File.Move("input/" + file, "output/pngs/" + file);
                }
                else if (file.Contains("test"))
                {
                    File.Move("input/" + file, "output/tests/" + file);
                }
                else if (file.Contains("txt"))
                {
                    File.Move("input/" + file, "output/txts/" + file);
                }
            }
        }
    }
}
