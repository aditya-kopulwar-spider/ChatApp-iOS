using System;
using Foundation;

namespace ChatApp
{
    public class ChatMessage : NSObject
    {
        public string Username
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public string Time
        {
            get;
            set;
        }

        public ChatMessage()
        {
        }

        public ChatMessage(string Message, string Username, string DateTime)
        {
            this.Username = Username;
            this.Message = Message;
            Time = DateTime;
        }
    }
}
