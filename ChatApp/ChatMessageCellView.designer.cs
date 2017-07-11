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
    [Register ("ChatMessageCellView")]
    partial class ChatMessageCellView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel dateTxt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel messageTxt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel usernameTxt { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dateTxt != null) {
                dateTxt.Dispose ();
                dateTxt = null;
            }

            if (messageTxt != null) {
                messageTxt.Dispose ();
                messageTxt = null;
            }

            if (usernameTxt != null) {
                usernameTxt.Dispose ();
                usernameTxt = null;
            }
        }
    }
}