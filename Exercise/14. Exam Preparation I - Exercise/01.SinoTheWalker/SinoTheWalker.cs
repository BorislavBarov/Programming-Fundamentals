namespace SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = double.Parse(Console.ReadLine());
            var secondsPerStep = double.Parse(Console.ReadLine());

            var secondsInADay = 60 * 60 * 24;
            var totalSeconds = (steps * secondsPerStep) % secondsInADay;
            var arrivalTime = leavingTime.AddSeconds(totalSeconds);

            Console.WriteLine("Time Arrival: {0}", arrivalTime.TimeOfDay);
        }
    }
}
