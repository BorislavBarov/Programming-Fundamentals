namespace GroupContinentsCountriesAndCities
{
    using System;
    using System.Collections.Generic;

    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var tokens = input.Split();
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!result.ContainsKey(continent))
                {
                    result[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!result[continent].ContainsKey(country))
                {
                    result[continent][country] = new SortedSet<string>();
                }

                result[continent][country].Add(city);
            }

            foreach (var continent in result)
            {
                Console.WriteLine("{0}:", continent.Key);

                foreach (var countriesAndCities in continent.Value)
                {
                    Console.WriteLine("  {0} -> {1}", countriesAndCities.Key, string.Join(", ", countriesAndCities.Value));
                }
            }
        }
    }
}
