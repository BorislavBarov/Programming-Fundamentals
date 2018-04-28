namespace CriticalBreakpoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class CriticalBreakpoint
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var lines = new List<Line>();

            while (inputLine != "Break it.")
            {
                var lineParams = inputLine.Split().Select(int.Parse).ToArray();

                var line = new Line()
                {
                    X1 = lineParams[0],
                    Y1 = lineParams[1],
                    X2 = lineParams[2],
                    Y2 = lineParams[3],
                    CriticalRatio = Math.Abs(((long)lineParams[2] + lineParams[3]) - ((long)lineParams[0] + lineParams[1]))
                };

                lines.Add(line);

                inputLine = Console.ReadLine();
            }

            var hasBreakpoint = true;
            BigInteger actualRatio = 0;

            foreach (var line in lines)
            {
                if (actualRatio == 0 && line.CriticalRatio != 0)
                {
                    actualRatio = line.CriticalRatio;
                }

                if (line.CriticalRatio != actualRatio && line.CriticalRatio != 0)
                {
                    hasBreakpoint = false;
                    break;
                }
            }

            if (hasBreakpoint)
            {
                BigInteger totalRatio = BigInteger.Pow(actualRatio, lines.Count);
                BigInteger criticalBreakpoint = 0;
                BigInteger.DivRem(totalRatio, lines.Count, out criticalBreakpoint);

                foreach (var line in lines)
                {
                    Console.WriteLine($"Line: [{line.X1}, {line.Y1}, {line.X2}, {line.Y2}]");
                }

                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}
