namespace Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var tokens = input.Split();
                var region = tokens[0];
                var shell = int.Parse(tokens[1]);

                if (!result.ContainsKey(region))
                {
                    result[region] = new HashSet<int>();
                }

                result[region].Add(shell);

                input = Console.ReadLine();
            }

            foreach (var regionAndShell in result)
            {
                Console.WriteLine(
                    "{0} -> {1} ({2})", 
                    regionAndShell.Key, 
                    string.Join(", ", regionAndShell.Value), 
                    Math.Ceiling(regionAndShell.Value.Sum() - regionAndShell.Value.Average()));
            }
        }
    }
}
