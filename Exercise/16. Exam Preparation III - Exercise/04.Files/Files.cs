namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var counter = 0;
            var storage = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var fileData = input.Last().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var root = input[0];
                var fileName = fileData[0];
                var fileSize = long.Parse(fileData[1]);

                if (storage.ContainsKey(root))
                {
                    if (storage[root].ContainsKey(fileName))
                    {
                        storage[root][fileName] = fileSize;
                    }
                    else
                    {
                        storage[root].Add(fileName, fileSize);
                    }
                }
                else
                {
                    storage.Add(root, new Dictionary<string, long> { { fileName, fileSize } });
                }
            }

            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var extension = command[0];
            var dir = command[2];

            var sorted = storage.Where(x => x.Key == dir).OrderByDescending(f => f.Value.Values);

            foreach (var r in sorted)
            {
                foreach (var item in r.Value.OrderByDescending(x => x.Value).ThenBy(z => z.Key))
                {
                    if (item.Key.Split('.').Last() == extension)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}