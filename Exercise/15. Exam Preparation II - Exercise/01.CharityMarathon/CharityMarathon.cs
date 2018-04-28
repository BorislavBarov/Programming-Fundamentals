namespace CharityMarathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var avaregeLaps = int.Parse(Console.ReadLine());
            var lapLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            decimal totalRunners = trackCapacity * days;

            if (totalRunners > runners)
            {
                totalRunners = runners;
            }

            var totalMeters = totalRunners * avaregeLaps * lapLength;
            var totalKilometers = totalMeters / 1000;
            var totalMoney = moneyPerKilometer * totalKilometers;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
