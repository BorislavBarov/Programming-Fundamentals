namespace AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var splitInput = input.Split();
                var name = splitInput[0];
                var grade = double.Parse(splitInput[1]);

                if (!result.ContainsKey(name))
                {
                    result[name] = new List<double>();
                }

                result[name].Add(grade);
            }

            foreach (var item in result)
            {
                Console.WriteLine(
                    "{0} -> {1} (avg: {2:f2})", 
                    item.Key, 
                    string.Join(" ", item.Value.Select(x => string.Format("{0:f2}", x))), 
                    item.Value.Average());
            }
        }
    }
}
