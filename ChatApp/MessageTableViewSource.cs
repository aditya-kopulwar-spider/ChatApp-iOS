using System;
using System.Collections.Generic;
using Firebase.Database;
using Foundation;
using UIKit;

namespace ChatApp
{
    public class MessageTableViewSource : UITableViewSource
    {
        List<ChatMessage> messages = new List<ChatMessage>();
        public MessageTableViewSource(List<ChatMessage> chatMessages)
        {
            messages = chatMessages;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            ChatMessageCellView cellView = (ChatMessageCellView)tableView.DequeueReusableCell("ChatMessageCell", indexPath);
            cellView.UpdateLabel(messages[indexPath.Row]);
            return cellView;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return messages.Count;
        }
    }
}
