namespace RemoveElementsAtOddPositions
{
    using System;
    using System.Linq;

    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(words[i]);
                }
            }

            Console.WriteLine();
        }
    }
}