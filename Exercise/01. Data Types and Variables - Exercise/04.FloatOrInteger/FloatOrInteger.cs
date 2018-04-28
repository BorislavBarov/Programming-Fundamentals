namespace FloatOrInteger
{
    using System;

    public class FloatOrInteger
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(num));
        }
    }
}