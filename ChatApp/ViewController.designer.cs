// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ChatApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button_login { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UsernameTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (button_login != null) {
                button_login.Dispose ();
                button_login = null;
            }

            if (UsernameTextField != null) {
                UsernameTextField.Dispose ();
                UsernameTextField = null;
            }
        }
    }
}