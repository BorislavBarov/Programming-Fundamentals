namespace JSONParse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JSONParse
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            var students = new List<Student>();
            
            foreach (var line in input)
            {
                var tokens = line
                    .Replace("name", " ")
                    .Replace("age", " ")
                    .Replace("grades", " ")
                    .Split(new[] { '{', '[', ':', '"', '}', ']', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var student = new Student
                {
                    Name = tokens[0],
                    Age = int.Parse(tokens[1]),
                    Grades = tokens.Skip(2).Select(int.Parse).ToList()
                };

                students.Add(student);
            }

            foreach (var student in students)
            {
                if (student.Grades.Count == 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
            }
        }
    }
}
