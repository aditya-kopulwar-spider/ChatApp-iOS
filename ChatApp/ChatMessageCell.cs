using System;
using Foundation;
using UIKit;

namespace ChatApp
{
    public class ChatMessageCell : UITableViewCell
    {
        private UITableView tableView;
        private NSIndexPath indexPath;
        private UILabel username;
        private UILabel date;
        private UILabel message;
        private ChatMessage chatMessage;

        public ChatMessageCell()
        {
        }

        public ChatMessageCell(UITableView tableView, NSIndexPath indexPath)
        {
            this.tableView = tableView;
            this.indexPath = indexPath;
            this.username = new UILabel();
            this.date = new UILabel();
            this.message = new UILabel();
        }

        public ChatMessageCell(UITableView tableView, NSIndexPath indexPath, ChatMessage chatMessage) : this(tableView, indexPath)
        {
            this.chatMessage = chatMessage;
        }

        internal ChatMessageCell LoadMessageCell()
        {
            var cell = tableView.DequeueReusableCell("messageCell", indexPath) as ChatMessageCell;
            cell.username.Text = chatMessage.Username;
            cell.date.Text = chatMessage.Time;
            cell.message.Text = chatMessage.Message;

            return cell;
        }
    }
}
