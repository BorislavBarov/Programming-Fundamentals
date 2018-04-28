namespace TrickyStrings
{
    using System;

    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            string result = null;
            string lastString = null;

            for (int i = 0; i < n; i++)
            {
                string randomText = Console.ReadLine();

                if (i == n - 1)
                {
                    lastString = randomText;
                    break;
                }

                result += randomText + delimiter;
            }

            Console.WriteLine(result + lastString);
        }
    }
}