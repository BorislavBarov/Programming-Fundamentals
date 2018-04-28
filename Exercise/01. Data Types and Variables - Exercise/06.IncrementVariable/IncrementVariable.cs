namespace IncrementVariable
{
    using System;

    public class IncrementVariable
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            byte byteValue = 0;

            for (int i = 0; i < n; i++)
            {
                byteValue++;
            }

            var overflowTimes = n / 256;

            if (overflowTimes != 0)
            {
                Console.WriteLine(byteValue);
                Console.WriteLine($"Overflowed {overflowTimes} times");
            }
            else
            {
                Console.WriteLine(byteValue);
            }
        }
    }
}