namespace StringEncryption
{
    using System;

    public class StringEncryption
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                result += Encrypt(letter);
            }

            Console.WriteLine(result);
        }

        public static string Encrypt(char letter)
        {
            var asciiCode = (int)letter;
            var firstDigit = 0;
            var lastDigit = asciiCode % 10;
            
            while (asciiCode > 0)
            {
                firstDigit = asciiCode % 10;
                asciiCode /= 10;
            }

            asciiCode = letter;
            string firstAndLastDigit = firstDigit.ToString() + lastDigit.ToString();
            var firstLetter = (char)(asciiCode + lastDigit);
            var lastLetter = (char)(asciiCode - firstDigit);
            string result = firstLetter + firstAndLastDigit + lastLetter;

            return result;
        }
    }
}