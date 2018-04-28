namespace HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());

            double distance = (n / 1000) * m;
            var flapsTime = n / 100;
            var flapsTimeAfterRest = (n / p) * 5;
            var totalTime = flapsTime + flapsTimeAfterRest;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
