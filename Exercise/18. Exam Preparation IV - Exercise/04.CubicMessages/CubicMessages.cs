namespace CubicMessages
{
    using System;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$";

            var line = Console.ReadLine();

            while (line != "Over!")
            {
                var match = Regex.Match(line, pattern);

                if (!match.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var messageLenght = int.Parse(Console.ReadLine());

                var message = match.Groups["message"].Value;

                if (message.Length != messageLenght)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var leftPart = match.Groups["leftPart"].Value;
                var rightPart = match.Groups["rightPart"].Value;
                var verificationCode = string.Empty;
                var verificationIndexes = leftPart + rightPart;

                foreach (var character in verificationIndexes)
                {
                    int index;
                    var isDigit = int.TryParse(character.ToString(), out index);
                    var isValidIndex = index >= 0 && index < message.Length;

                    if (isDigit && isValidIndex)
                    {
                        var messageChar = message[index];
                        verificationCode += messageChar;
                    }
                    else
                    {
                        verificationCode += " ";
                    }
                }

                Console.WriteLine($"{message} == {verificationCode}");
                line = Console.ReadLine();
            }
        }
    }
}
