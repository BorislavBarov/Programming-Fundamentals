namespace TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklistedWords = Console.ReadLine().Split(' ').ToList();
            
            var result = new List<string>();

            for (int i = 0; ; i++)
            {
                var filenames = Console.ReadLine();

                if (filenames == "end")
                {
                    break;
                }

                bool exist = false;

                for (int i2 = 0; i2 < blacklistedWords.Count; i2++)
                {
                    if (filenames.Contains(blacklistedWords[i2]))
                    {
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    result.Add(filenames);
                }
            }

            result.Sort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}