using Foundation;
using System;
using UIKit;

namespace ChatApp
{
    public partial class ChatMessageCellView : UITableViewCell
    {
        public ChatMessageCellView (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateLabel(ChatMessage chatMessage)
        {
            messageTxt.Text = chatMessage.Message;
            dateTxt.Text = chatMessage.Time;
            usernameTxt.Text = chatMessage.Username;
        }
    }
}