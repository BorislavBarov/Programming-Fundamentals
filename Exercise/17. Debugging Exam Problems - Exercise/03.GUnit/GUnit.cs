namespace GUnit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class GUnit
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var regex = new Regex(@"^([A-Z][a-zA-Z0-9]+) \| ([A-Z][a-zA-Z0-9]+) \| ([A-Z][a-zA-Z0-9]+)$");
            var classes = new Dictionary<string, Dictionary<string, List<string>>>();

            while (inputLine != "It's testing time!")
            {
                if (regex.IsMatch(inputLine))
                {
                    var match = regex.Match(inputLine);

                    var className = match.Groups[1].Value;
                    var methodName = match.Groups[2].Value;
                    var unitTestName = match.Groups[3].Value;

                    if (!classes.ContainsKey(className))
                    {
                        classes[className] = new Dictionary<string, List<string>>();
                    }

                    if (!classes[className].ContainsKey(methodName))
                    {
                        classes[className][methodName] = new List<string>();
                    }

                    if (!classes[className][methodName].Contains(unitTestName))
                    {
                        classes[className][methodName].Add(unitTestName);
                    }
                }

                inputLine = Console.ReadLine();
            }

            var sortedClasses = classes
                .OrderByDescending(x => x.Value.Values.Sum(y => y.Count))
                .ThenBy(x => x.Value.Count)
                .ThenBy(x => x.Key, StringComparer.Ordinal)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var classEntry in sortedClasses)
            {
                Console.WriteLine(classEntry.Key + ":");

                var sortedMethods = classEntry.Value
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);

                foreach (var methodEntry in sortedMethods)
                {
                    Console.WriteLine("##" + methodEntry.Key);

                    var sortedUnitTests = methodEntry.Value
                        .OrderBy(x => x.Length)
                        .ThenBy(x => x, StringComparer.Ordinal)
                        .ToList();

                    foreach (var unitTestEntry in sortedUnitTests)
                    {
                        Console.WriteLine("####" + unitTestEntry);
                    }
                }
            }
        }
    }
}
