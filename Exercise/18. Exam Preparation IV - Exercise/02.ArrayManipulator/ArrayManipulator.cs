namespace ArrayManipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "end")
            {
                var splitCommand = command.Split();

                switch (splitCommand[0])
                {
                    case "exchange":
                        var index = int.Parse(splitCommand[1]);

                        if (index < 0 || index > array.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        var firstPart = array.Take(index + 1).ToList();
                        var secondPart = array.Skip(index + 1).ToList();
                        array.Clear();
                        array = secondPart.Concat(firstPart).ToList();
                        break;

                    case "max":
                        if (splitCommand[1] == "even")
                        {
                            var maxEvenElement = int.MinValue;
                            var maxEvenElementIndex = -1;

                            for (int i = 0; i < array.Count; i++)
                            {
                                if (array[i] % 2 == 0 && array[i] >= maxEvenElement)
                                {
                                    maxEvenElement = array[i];
                                    maxEvenElementIndex = i;
                                }
                            }

                            if (maxEvenElementIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxEvenElementIndex);
                            }
                        }
                        else if (splitCommand[1] == "odd")
                        {
                            var maxOddElement = int.MinValue;
                            var maxOddElementIndex = -1;

                            for (int i = 0; i < array.Count; i++)
                            {
                                if (array[i] % 2 != 0 && array[i] >= maxOddElement)
                                {
                                    maxOddElement = array[i];
                                    maxOddElementIndex = i;
                                }
                            }

                            if (maxOddElementIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxOddElementIndex);
                            }
                        }

                        break;

                    case "min":
                        if (splitCommand[1] == "even")
                        {
                            var minEvenElement = int.MaxValue;
                            var minEvenElementIndex = -1;

                            for (int i = 0; i < array.Count; i++)
                            {
                                if (array[i] % 2 == 0 && array[i] <= minEvenElement)
                                {
                                    minEvenElement = array[i];
                                    minEvenElementIndex = i;
                                }
                            }

                            if (minEvenElementIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minEvenElementIndex);
                            }
                        }
                        else if (splitCommand[1] == "odd")
                        {
                            var minOddElement = int.MaxValue;
                            var minOddElementIndex = -1;

                            for (int i = 0; i < array.Count; i++)
                            {
                                if (array[i] % 2 != 0 && array[i] <= minOddElement)
                                {
                                    minOddElement = array[i];
                                    minOddElementIndex = i;
                                }
                            }

                            if (minOddElementIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minOddElementIndex);
                            }
                        }

                        break;

                    case "first":
                        var firstCount = int.Parse(splitCommand[1]);

                        if (firstCount > array.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (splitCommand[2] == "even")
                        {
                            var firstEvenNumbers = array.Where(x => x % 2 == 0).Take(firstCount).ToList();
                            Console.WriteLine("[" + string.Join(", ", firstEvenNumbers) + "]");
                        }
                        else if (splitCommand[2] == "odd")
                        {
                            var firstOddNumbers = array.Where(x => x % 2 != 0).Take(firstCount).ToList();
                            Console.WriteLine("[" + string.Join(", ", firstOddNumbers) + "]");
                        }

                        break;

                    case "last":
                        var lastCount = int.Parse(splitCommand[1]);

                        if (lastCount > array.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (splitCommand[2] == "even")
                        {
                            var lastEvenNumbers = array.Where(x => x % 2 == 0).Reverse().Take(lastCount).Reverse().ToList();
                            Console.WriteLine("[" + string.Join(", ", lastEvenNumbers) + "]");
                        }
                        else if (splitCommand[2] == "odd")
                        {
                            var lastOddNumbers = array.Where(x => x % 2 != 0).Reverse().Take(lastCount).Reverse().ToList();
                            Console.WriteLine("[" + string.Join(", ", lastOddNumbers) + "]");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
    }
}
