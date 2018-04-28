namespace WinningTicket
{
    using System;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            var regex = new Regex(@"([$]{6,})|([#]{6,})|([@]{6,})|([\^]{6,})");

            foreach (var ticket in input)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftHalf = ticket.Substring(0, ticket.Length / 2);
                var rightHalf = ticket.Substring(ticket.Length / 2);

                var matchLeftHalf = regex.Match(leftHalf);
                var matchRightHalf = regex.Match(rightHalf);
                
                if (matchLeftHalf.Success && matchRightHalf.Success)
                {
                    var shortLenght = Math.Min(matchLeftHalf.Length, matchRightHalf.Length);
                    var symbol = matchLeftHalf.Value[0];
                    var jackpot = string.Empty;

                    if (matchLeftHalf.Length == 10 && matchRightHalf.Length == 10)
                    {
                        jackpot = " Jackpot!";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {shortLenght}{symbol}{jackpot}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
