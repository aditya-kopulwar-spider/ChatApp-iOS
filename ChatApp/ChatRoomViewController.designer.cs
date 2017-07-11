// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ChatApp
{
    [Register ("ChatRoomViewController")]
    partial class ChatRoomViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField inputMessage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView MessageTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton sendButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (inputMessage != null) {
                inputMessage.Dispose ();
                inputMessage = null;
            }

            if (MessageTableView != null) {
                MessageTableView.Dispose ();
                MessageTableView = null;
            }

            if (sendButton != null) {
                sendButton.Dispose ();
                sendButton = null;
            }
        }
    }
}