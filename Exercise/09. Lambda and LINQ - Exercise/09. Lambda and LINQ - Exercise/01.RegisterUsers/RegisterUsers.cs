namespace RegisterUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RegisterUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var registrations = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', '/' }, StringSplitOptions.RemoveEmptyEntries);
                var user = tokens[0];
                var day = int.Parse(tokens[1]);
                var month = int.Parse(tokens[2]);
                var year = int.Parse(tokens[3]);
                DateTime date = new DateTime(year, month, day);
                
                registrations[user] = date;
                
                input = Console.ReadLine();
            }

            var result = registrations
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var userName in result.Keys)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
