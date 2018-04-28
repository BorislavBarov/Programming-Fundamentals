namespace Placeholders
{
    using System;
    using System.Collections.Generic;

    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            
            while (input != "end")
            {
                var inputParts = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var str = inputParts[0];
                var elements = new List<string>();

                foreach (var element in inputParts[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    elements.Add(element);
                }

                for (int i = 0; i < elements.Count; i++)
                {
                    str = str.Replace('{' + $"{i}" + '}', elements[i]);
                }

                Console.WriteLine(str);

                input = Console.ReadLine();
            }
        }
    }
}
