namespace JSONStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class JSONStringify
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var students = new List<Student>();

            while (input != "stringify")
            {
                var inputParts = input.Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var student = new Student();
                student.Name = inputParts[0];
                student.Age = int.Parse(inputParts[1]);
                student.Grades = inputParts.Skip(2).Select(int.Parse).ToList();
                students.Add(student);

                input = Console.ReadLine();
            }

            var result = new StringBuilder();
            result.Append('[');

            foreach (var student in students)
            {
                result.Append($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
            }

            result.Remove(result.Length - 1, 1);
            result.Append(']');

            Console.WriteLine(result.ToString());
        }
    }
}
