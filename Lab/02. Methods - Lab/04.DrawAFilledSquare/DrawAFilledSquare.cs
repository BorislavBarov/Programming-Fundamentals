namespace DrawAFilledSquare
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            PrintHeaderRow(n);

            for (int i = 1; i < n - 1; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderRow(n);
        }

        public static void PrintMiddleRow(int n)
        {
            Console.Write("-");

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }

        public static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}