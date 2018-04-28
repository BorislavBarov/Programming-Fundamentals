using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var continentData = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!continentData.ContainsKey(continent))
                {
                    continentData[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent][country] = new List<string>();
                }

                continentData[continent][country].Add(city);
            }

            foreach (var continentCounties in continentData)
            {
                var continentName = continentCounties.Key;
                var countries = continentCounties.Value;

                Console.WriteLine($"{continentName}:");
                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;

                    Console.WriteLine("  {0} -> {1}", countryName, string.Join(", ", cities));
                }
            }
        }
    }
}