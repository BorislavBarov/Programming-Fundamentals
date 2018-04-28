namespace RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var eventsById = new Dictionary<int, string>();
            var partsByEvent = new Dictionary<string, List<string>>();

            while (!input.Equals("Time for Code"))
            {
                if (input.Contains("#"))
                {
                    var inputParts = input.Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries);
                    var id = int.Parse(inputParts[0]);
                    var eventName = inputParts[1];

                    var participiants = new List<string>();

                    if (inputParts.Length > 2)
                    {
                        for (int i = 2; i < inputParts.Length; i++)
                        {
                            participiants.Add(inputParts[i]);
                        }
                    }

                    if (!eventsById.ContainsKey(id))
                    {
                        eventsById.Add(id, eventName);
                        partsByEvent.Add(eventName, participiants);
                    }
                    else if (eventsById[id] == eventName)
                    {
                        partsByEvent[eventName].AddRange(participiants);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var part in partsByEvent.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{part.Key} - {part.Value.Distinct().Count()}");

                foreach (var val in part.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine(val);
                }
            }
        }
    }
}
