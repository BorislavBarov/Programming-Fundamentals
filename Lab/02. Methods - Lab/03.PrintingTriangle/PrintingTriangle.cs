namespace PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        public static void PrintLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        public static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
    }
}