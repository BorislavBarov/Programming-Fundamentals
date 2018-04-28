namespace HelloName
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            PrintName();
        }

        public static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}