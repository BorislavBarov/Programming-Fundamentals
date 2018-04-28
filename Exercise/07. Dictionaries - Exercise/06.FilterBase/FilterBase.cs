namespace FilterBase
{
    using System;
    using System.Collections.Generic;

    public class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, double>();
            var positionDict = new Dictionary<string, string>();

            while (input != "filter base")
            {
                var splitInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = splitInput[0];
                var lastElement = splitInput[splitInput.Length - 1];

                var age = 0;
                var salary = 0d;

                if (int.TryParse(lastElement, out age))
                {
                    ageDict[name] = age;
                }
                else if (double.TryParse(lastElement, out salary))
                {
                    salaryDict[name] = salary;
                }
                else
                {
                    positionDict[name] = lastElement;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            switch (input)
            {
                case "Age":
                    foreach (var item in ageDict)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Age: {item.Value}");
                        Console.WriteLine(new string('=', 20));
                    }

                    break;

                case "Salary":
                    foreach (var item in salaryDict)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Salary: {item.Value:f2}");
                        Console.WriteLine(new string('=', 20));
                    }

                    break;

                case "Position":
                    foreach (var item in positionDict)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Position: {item.Value}");
                        Console.WriteLine(new string('=', 20));
                    }

                    break;
            }
        }
    }
}
