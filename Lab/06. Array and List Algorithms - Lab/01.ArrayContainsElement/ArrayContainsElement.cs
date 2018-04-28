namespace ArrayContainsElement
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    Console.WriteLine("yes");
                    isFound = true;
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
