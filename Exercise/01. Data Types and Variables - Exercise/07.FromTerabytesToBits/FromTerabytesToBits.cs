namespace FromTerabytesToBits
{
    using System;

    public class FromTerabytesToBits
    {
        public static void Main()
        {
            var terabyte = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0:f0}", terabyte * 8796093022208);
        }
    }
}