namespace EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver[0];
                var reach = 0;
                
                for (int i = 0; i < zones.Length; i++)
                {
                    if (indexes.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }

                    if (fuel <= 0)
                    {
                        reach = i;
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {reach}");
                }
            }
        }
    }
}
