namespace CommandInterpreter
{
    using System;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var collection = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split();
                var command = inputParams[0];
                
                if (command == "reverse")
                {
                    var startIndex = int.Parse(inputParams[2]);
                    var count = int.Parse(inputParams[4]);

                    if (startIndex >= 0 && startIndex < collection.Count && count >= 0 && (startIndex + count) <= collection.Count)
                    {
                        collection.Reverse(startIndex, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command == "sort")
                {
                    var startIndex = int.Parse(inputParams[2]);
                    var count = int.Parse(inputParams[4]);

                    if (startIndex >= 0 && startIndex < collection.Count && count >= 0 && (startIndex + count) <= collection.Count)
                    {
                        collection.Sort(startIndex, count, null);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command == "rollLeft")
                {
                    var count = int.Parse(inputParams[1]);
                    
                    if (count >= 0)
                    {
                        var rotations = count % collection.Count;

                        for (int i = 0; i < rotations; i++)
                        {
                            var firstElement = collection[0];

                            for (int j = 0; j < collection.Count - 1; j++)
                            {
                                collection[j] = collection[j + 1];
                            }

                            collection[collection.Count - 1] = firstElement;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command == "rollRight")
                {
                    var count = int.Parse(inputParams[1]);
                    
                    if (count >= 0)
                    {
                        var rotations = count % collection.Count;

                        for (int i = 0; i < rotations; i++)
                        {
                            var lastElement = collection[collection.Count - 1];

                            for (int j = collection.Count - 1; j > 0; j--)
                            {
                                collection[j] = collection[j - 1];
                            }

                            collection[0] = lastElement;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }
    }
}
