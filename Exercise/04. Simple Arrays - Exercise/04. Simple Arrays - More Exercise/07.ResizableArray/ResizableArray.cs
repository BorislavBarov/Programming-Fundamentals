namespace ResizableArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ResizableArray
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            List<int> result = new List<int>();

            while (!input[0].Equals("end"))
            {
                if (input[0].Equals("push"))
                {
                    result.Add(int.Parse(input[1]));
                }
                else if (input[0].Equals("pop"))
                {
                    result.RemoveAt(result.Count - 1);
                }
                else if (input[0].Equals("removeAt"))
                {
                    result.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0].Equals("clear"))
                {
                    result.Clear();
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}