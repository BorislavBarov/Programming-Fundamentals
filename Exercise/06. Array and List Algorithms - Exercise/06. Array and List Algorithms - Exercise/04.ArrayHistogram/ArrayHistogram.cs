namespace ArrayHistogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayHistogram
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();

            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (words.Contains(input[i]))
                {
                    var wordIndex = words.IndexOf(input[i]);
                    counts[wordIndex]++;
                }
                else
                {
                    words.Add(input[i]);
                    counts.Add(1);
                }
            }
            
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < words.Count - 1; i++)
                {
                    if (counts[i] < counts[i + 1])
                    {
                        var temp = counts[i];
                        counts[i] = counts[i + 1];
                        counts[i + 1] = temp;

                        var tempWord = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempWord;

                        swapped = true;
                    }
                }
            }
            while (swapped);

            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (counts[i] * 100.0) / input.Count;
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", words[i], counts[i], percentage);
            }
        }
    }
}
