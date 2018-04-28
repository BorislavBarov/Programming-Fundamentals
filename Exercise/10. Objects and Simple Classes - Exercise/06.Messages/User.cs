namespace Messages
{
    using System.Collections.Generic;

    public class User
    {
        public string Username { get; set; }

        public List<Message> ReceivedMessages { get; set; }
    }
}
