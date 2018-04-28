namespace Transport
{
    using System;

    public class Transport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 4 + 8 + 12;
            double courses = Math.Ceiling((double)n / capacity);

            Console.WriteLine(courses);
        }
    }
}
