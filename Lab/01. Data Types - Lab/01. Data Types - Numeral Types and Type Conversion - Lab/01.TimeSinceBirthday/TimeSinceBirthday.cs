namespace TimeSinceBirthday
{
    using System;

    public class TimeSinceBirthday
    {
        public static void Main()
        {
            Console.Write("Years - ");
            byte years = byte.Parse(Console.ReadLine());

            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", years, days, hours, minutes);
        }
    }
}