namespace Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Websites
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var listOfWebsites = new List<Website>();

            while (input != "end")
            {
                var inputParts = input.Split(new[] { ' ', ',', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var websites = new Website
                {
                    Host = inputParts[0],
                    Domain = inputParts[1],
                    Queries = null
                };
                
                if (inputParts.Length > 2)
                {
                    websites.Queries = inputParts.Skip(2).ToList();
                }

                listOfWebsites.Add(websites);

                input = Console.ReadLine();
            }

            foreach (var website in listOfWebsites)
            {
                if (website.Queries != null)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[", website.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }
    }
}
