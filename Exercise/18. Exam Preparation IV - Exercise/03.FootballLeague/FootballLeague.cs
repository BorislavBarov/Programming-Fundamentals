namespace FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FootballLeague
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());
            var inputLine = Console.ReadLine();

            var pattern = $@".*{key}([A-Za-z]*){key}.* .*{key}([A-Za-z]*){key}.* (\d+):(\d+)";
            var regex = new Regex(pattern);

            var points = new Dictionary<string, int>();
            var goals = new Dictionary<string, int>();

            while (inputLine != "final")
            {
                var match = regex.Match(inputLine);
                var teamA = new string(match.Groups[1].Value.ToUpper().Reverse().ToArray());
                var teamB = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());
                var goalsTeamA = int.Parse(match.Groups[3].Value);
                var goalsTeamB = int.Parse(match.Groups[4].Value);

                if (!points.ContainsKey(teamA))
                {
                    points[teamA] = 0;
                }

                if (!points.ContainsKey(teamB))
                {
                    points[teamB] = 0;
                }

                if (!goals.ContainsKey(teamA))
                {
                    goals[teamA] = 0;
                }

                if (!goals.ContainsKey(teamB))
                {
                    goals[teamB] = 0;
                }

                if (goalsTeamA == goalsTeamB)
                {
                    points[teamA]++;
                    points[teamB]++;
                }
                else if (goalsTeamA > goalsTeamB)
                {
                    points[teamA] += 3;
                }
                else if (goalsTeamA < goalsTeamB)
                {
                    points[teamB] += 3;
                }

                goals[teamA] += goalsTeamA;
                goals[teamB] += goalsTeamB;

                inputLine = Console.ReadLine();
            }

            points = points
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            goals = goals
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Take(3)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("League standings:");

            var place = 1;

            foreach (var teamAndPoints in points)
            {
                Console.WriteLine($"{place}. {teamAndPoints.Key} {teamAndPoints.Value}");
                place++;
            }

            place = 1;

            Console.WriteLine("Top 3 scored goals:");

            foreach (var teamAndGoals in goals)
            {
                Console.WriteLine($"- {teamAndGoals.Key} -> {teamAndGoals.Value}");
                place++;
            }
        }
    }
}
