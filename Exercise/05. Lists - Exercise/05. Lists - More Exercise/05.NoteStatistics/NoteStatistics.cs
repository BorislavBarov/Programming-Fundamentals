namespace NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteStatistics
    {
        public static void Main()
        {
            var inputFrequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var initionNotes = "C C# D D# E F F# G G# A A# B".Split().ToList();
            var frequencies = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88".Split().Select(double.Parse).ToList();

            var currentNotes = new List<string>();

            for (int i = 0; i < inputFrequencies.Count; i++)
            {
                for (int j = 0; j < frequencies.Count; j++)
                {
                    if (inputFrequencies[i] == frequencies[j])
                    {
                        currentNotes.Add(initionNotes[j]);
                    }
                }
            }

            var naturalNotes = new List<string>();
            var notesWithSharp = new List<string>();

            for (int i = 0; i < currentNotes.Count; i++)
            {
                if (!currentNotes[i].Contains("#"))
                {
                    naturalNotes.Add(currentNotes[i]);
                }
                else
                {
                    notesWithSharp.Add(currentNotes[i]);
                }
            }

            double naturalsSum = 0;

            for (int i = 0; i < naturalNotes.Count; i++)
            {
                for (int j = 0; j < initionNotes.Count; j++)
                {
                    if (naturalNotes[i] == initionNotes[j])
                    {
                        naturalsSum += frequencies[j];
                    }
                }
            }

            double sharpsSum = 0;

            for (int i = 0; i < notesWithSharp.Count; i++)
            {
                for (int j = 0; j < initionNotes.Count; j++)
                {
                    if (notesWithSharp[i] == initionNotes[j])
                    {
                        sharpsSum += frequencies[j];
                    }
                }
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", currentNotes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturalNotes));
            Console.WriteLine("Sharps: {0}", string.Join(", ", notesWithSharp));
            Console.WriteLine("Naturals sum: {0}", naturalsSum);
            Console.WriteLine("Sharps sum: {0}", sharpsSum);
        }
    }
}