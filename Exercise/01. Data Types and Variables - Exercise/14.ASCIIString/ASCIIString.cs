namespace ASCIIString
{
    using System;

    public class ASCIIString
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string asciiString = null;

            for (int i = 0; i < n; i++)
            {
                var asciiNumber = int.Parse(Console.ReadLine());

                asciiString += (char)asciiNumber;
            }

            Console.WriteLine(asciiString);
        }
    }
}