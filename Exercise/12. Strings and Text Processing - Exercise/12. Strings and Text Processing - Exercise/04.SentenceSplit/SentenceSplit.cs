namespace SentenceSplit
{
    using System;

    public class SentenceSplit
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var delimiter = Console.ReadLine();

            var result = text.Replace(delimiter, ", ");

            Console.WriteLine("[" + result + "]");
        }
    }
}
