namespace ForumTopics
{
    using System;
    using System.Collections.Generic;

    public class ForumTopics
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = tokens[0];
                var tags = new HashSet<string>();

                foreach (var tag in tokens)
                {
                    tags.Add(tag);
                }

                tags.Remove(topic);

                if (!result.ContainsKey(topic))
                {
                    result[topic] = new HashSet<string>();
                }

                foreach (var tag in tags)
                {
                    result[topic].Add(tag);
                }

                input = Console.ReadLine();
            }

            var filterTag = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var item in result)
            {
                var counter = 0;

                foreach (var tag in filterTag)
                {
                    if (item.Value.Contains(tag))
                    {
                        counter++;
                    }
                }

                if (counter == filterTag.Length)
                {
                    Console.WriteLine("{0} | #{1}", item.Key, string.Join(", #", item.Value));
                }
            }
        }
    }
}