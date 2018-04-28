namespace TriplesOfLatinLetters
{
    using System;

    public class TriplesOfLatinLetters
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int firstLetter = 0; firstLetter < n; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < n; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < n; thirdLetter++)
                    {
                        Console.WriteLine($"{(char)(firstLetter + 'a')}{(char)(secondLetter + 'a')}{(char)(thirdLetter + 'a')}");
                    }
                }
            }
        }
    }
}
