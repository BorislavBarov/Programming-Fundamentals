namespace HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HornetComm
    {
        public static void Main()
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Hornet is Green")
                {
                    break;
                }

                var parts = line.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < 2)
                {
                    continue;
                }

                var firstQuery = parts[0];
                var secondQuery = parts[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    var reversedQuery = new string(firstQuery.Reverse().ToArray());

                    messages.Add($"{reversedQuery} -> {secondQuery}");
                }
                else if (firstQuery.All(x => !char.IsDigit(x)) && secondQuery.All(char.IsLetterOrDigit))
                {
                    var transformed = new StringBuilder();

                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            transformed.Append(char.ToLower(symbol));
                        }
                        else if (char.IsLower(symbol))
                        {
                            transformed.Append(char.ToUpper(symbol));
                        }
                        else
                        {
                            transformed.Append(symbol);
                        }
                    }

                    broadcasts.Add($"{transformed.ToString()} -> {firstQuery}");
                }
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Any())
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Any())
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
