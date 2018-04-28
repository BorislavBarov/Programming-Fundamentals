namespace Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Messages
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var users = new List<User>();

            while (input != "exit")
            {
                var inputParts = input.Split(' ');

                if (inputParts[0] == "register")
                {
                    var newUser = new User()
                    {
                        Username = inputParts[1],
                        ReceivedMessages = new List<Message>()
                    };

                    if (!users.Contains(newUser))
                    {
                        users.Add(newUser);
                    }
                }
                else
                {
                    var senderName = inputParts[0];
                    var recipientUsername = inputParts[2];

                    var newMessage = new Message();
                    newMessage.Content = inputParts[3];
                    newMessage.Sender = new User()
                    {
                        Username = senderName,
                        ReceivedMessages = new List<Message>()
                    };

                    var ifContainsSender = users
                        .Where(x => x.Username == senderName)
                        .ToArray();

                    var ifContainsRecipient = users
                        .Where(x => x.Username == recipientUsername)
                        .ToArray();

                    if (ifContainsSender.Count() > 0 && ifContainsRecipient.Count() > 0)
                    {
                        var recipientMessages = users
                            .FirstOrDefault(x => x.Username == recipientUsername);

                        if (recipientMessages != null)
                        {
                            recipientMessages.ReceivedMessages.Add(newMessage);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var finalInput = Console.ReadLine().Split(' ').ToArray();

            var first = finalInput[0];
            var second = finalInput[1];

            var messagesFromFirstToSecond = users
                .Where(x => x.Username == second)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == first)
                .Count();

            var messagesFromSecondToFirst = users
                .Where(x => x.Username == first)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == second)
                .Count();

            if (messagesFromFirstToSecond == 0 && messagesFromSecondToFirst == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {
                for (int i = 0; i < Math.Max(messagesFromFirstToSecond, messagesFromSecondToFirst); i++)
                {
                    var message = string.Empty;

                    if (i < messagesFromFirstToSecond)
                    {
                        message = users
                            .Where(x => x.Username == second)
                            .SelectMany(x => x.ReceivedMessages)
                            .Where(x => x.Sender.Username == first)
                            .Select(x => x.Content)
                            .ToList()[i];

                        Console.WriteLine($"{first}: {message}");
                    }

                    if (i < messagesFromSecondToFirst)
                    {
                        message = users
                            .Where(x => x.Username == first)
                            .SelectMany(x => x.ReceivedMessages)
                            .Where(x => x.Sender.Username == second)
                            .Select(x => x.Content)
                            .ToList()[i];

                        Console.WriteLine($"{message} :{second}");
                    }
                }
            }
        }
    }
}
