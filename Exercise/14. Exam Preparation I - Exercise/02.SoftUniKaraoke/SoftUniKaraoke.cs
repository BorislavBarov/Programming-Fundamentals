namespace SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            var songs = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            var inputLine = Console.ReadLine();

            var awards = new Dictionary<string, SortedSet<string>>();

            while (inputLine != "dawn")
            {
                var inputLineParts = inputLine
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToArray();

                var participant = inputLineParts[0];
                var song = inputLineParts[1];

                if (!participants.Contains(participant) || !songs.Contains(song))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (!awards.ContainsKey(participant))
                {
                    awards[participant] = new SortedSet<string>();
                }

                var award = inputLineParts[2];
                awards[participant].Add(award);

                inputLine = Console.ReadLine();
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            awards = awards
                .OrderByDescending(y => y.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            
            foreach (var item in awards)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                Console.WriteLine("--" + string.Join(Environment.NewLine + "--", item.Value));
            }
        }
    }
}
