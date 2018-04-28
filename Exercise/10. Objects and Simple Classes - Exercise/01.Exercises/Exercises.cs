namespace Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercises
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "go go go")
            {
                var inputParts = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var result = new Exercise
                {
                    Topic = inputParts[0],
                    CourseName = inputParts[1],
                    JudgeContestLink = inputParts[2],
                    Problems = inputParts.Skip(3).ToList()
                };
                
                Console.WriteLine($"Exercises: {result.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{result.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {result.JudgeContestLink}");

                var counter = 1;

                foreach (var problem in result.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }

                input = Console.ReadLine();
            }
        }
    }
}
