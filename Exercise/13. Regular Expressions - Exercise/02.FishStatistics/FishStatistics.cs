namespace FishStatistics
{
    using System;
    using System.Text.RegularExpressions;

    public class FishStatistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"(>*)<+(\(+)(\'|-|x)>");
            var matches = regex.Matches(input);
            var counter = 1;

            if (!regex.IsMatch(input))
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                foreach (Match fish in matches)
                {
                    Console.WriteLine($"Fish {counter}: {fish.Value}");
                    counter++;

                    var tailLength = fish.Groups[1].Value.Length;

                    if (tailLength > 5)
                    {
                        Console.WriteLine($"  Tail type: Long ({tailLength * 2} cm)");
                    }
                    else if (tailLength > 1 && tailLength <= 5)
                    {
                        Console.WriteLine($"  Tail type: Medium ({tailLength * 2} cm)");
                    }
                    else if (tailLength == 1)
                    {
                        Console.WriteLine($"  Tail type: Short ({tailLength * 2} cm)");
                    }
                    else if (tailLength == 0)
                    {
                        Console.WriteLine($"  Tail type: None");
                    }

                    var bodyLength = fish.Groups[2].Value.Length;

                    if (bodyLength > 10)
                    {
                        Console.WriteLine($"  Body type: Long ({bodyLength * 2} cm)");
                    }
                    else if (bodyLength > 5 && bodyLength <= 10)
                    {
                        Console.WriteLine($"  Body type: Medium ({bodyLength * 2} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"  Body type: Short ({bodyLength * 2} cm)");
                    }
                    
                    if (fish.Value.Contains("'"))
                    {
                        Console.WriteLine("  Status: Awake");
                    }
                    else if (fish.Value.Contains("-"))
                    {
                        Console.WriteLine("  Status: Asleep");
                    }
                    else if (fish.Value.Contains("x"))
                    {
                        Console.WriteLine("  Status: Dead");
                    }
                }
            }
        }
    }
}
