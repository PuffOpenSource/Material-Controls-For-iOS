// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
    [Register ("ToastView")]
    partial class ToastView
    {
        [Outlet]
        UIKit.UITextField MessageTextField { get; set; }


        [Action ("ButtonClicked:")]
        partial void ButtonClicked (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (MessageTextField != null) {
                MessageTextField.Dispose ();
                MessageTextField = null;
            }
        }
    }
}