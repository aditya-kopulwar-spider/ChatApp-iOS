using System;
using System.Collections.Generic;
using Firebase.Database;
using Foundation;
using UIKit;

namespace ChatApp
{
    public partial class ChatRoomViewController : UIViewController
    {
        DatabaseReference rootNode;
        DatabaseReference chatNode;
        List<ChatMessage> messages = new List<ChatMessage>();

        public string Username
        {
            get;
            set;
        }

        public ChatRoomViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            rootNode = Database.DefaultInstance.GetRootReference();

            MessageTableView.Source = new MessageTableViewSource(messages);

            chatNode = rootNode.GetChild("chats");

            LoadChatMessageList();

            sendButton.TouchUpInside += (sender, ea) =>
            {
                UploadMessageToFD();
            };
		}

        void UploadMessageToFD()
        {
            string currentTime = DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss");
            string messageText = inputMessage.Text;
            inputMessage.Text = "";

            object[] keys = { "Message", "Time", "User"};
            object[] values = { messageText, currentTime, Username };

            var data = NSDictionary.FromObjectsAndKeys(values, keys, keys.Length);

            chatNode.GetChildByAutoId().SetValue(data);
        }

        void LoadChatMessageList()
        {
            nuint handleReference = chatNode.ObserveEvent(DataEventType.Value, (snapshot) =>
            {
                messages.Clear();
                var chatData = snapshot.GetValue() as NSDictionary;
                foreach (NSObject key in chatData.Keys)
                {
                    var MessageData = chatData.ValueForKey((NSString)key) as NSDictionary;
                    ChatMessage message = new ChatMessage();
                    foreach (var item in MessageData.Keys)
                    {
                        var nSObject = (NSString)MessageData.ValueForKey((NSString)item);
                        String messageData = nSObject.ToString();

                        if ((item.ToString()).Equals("Message"))
                        {
                            message.Message = messageData;
                            continue;
                        }

                        if ((item.ToString()).Equals("Time"))
                        {
                            message.Time = messageData;
                            continue;
                        }
                        message.Username = messageData;
                    }
                    messages.Add(message);
                }
                MessageTableView.ReloadData();
            });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}