﻿namespace Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Winecraft
    {
        public static void Main()
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count > growthDays)
            {
                for (int currentRound = 0; currentRound < growthDays; currentRound++)
                {
                    IncrementGrapes(grapes);

                    for (int i = 0; i < grapes.Count; i++)
                    {
                        ProcessGrapes(grapes, i);
                    }
                }

                RemoveLesserGrapes(grapes, growthDays);
            }

            Console.WriteLine(string.Join(" ", grapes));
        }

        public static void IncrementGrapes(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                grapes[i]++;
            }
        }

        public static void ProcessGrapes(List<int> grapes, int i)
        {
            var isFirstElement = i == 0;
            var isLastElement = i == grapes.Count - 1;

            if (!isFirstElement && !isLastElement)
            {
                var previousIndex = i - 1;
                var nextIndex = i + 1;

                var isGreaterThanPrevious = grapes[i] > grapes[previousIndex];
                var isGreaterThanNext = grapes[i] > grapes[nextIndex];
                var isGreaterGrape = isGreaterThanNext && isGreaterThanPrevious;
                if (isGreaterGrape)
                {
                    grapes[i]--;

                    if (grapes[previousIndex] > 0)
                    {
                        grapes[i]++;
                        grapes[previousIndex] = Math.Max(grapes[previousIndex] - 2, 0);
                    }

                    if (grapes[nextIndex] > 0)
                    {
                        grapes[i]++;
                        grapes[nextIndex] = Math.Max(grapes[nextIndex] - 2, 0);
                    }
                }
            }
        }

        public static void RemoveLesserGrapes(List<int> grapes, int n)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= n)
                {
                    grapes.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
