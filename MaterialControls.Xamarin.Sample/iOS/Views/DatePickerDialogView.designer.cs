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
    [Register ("DatePickerDialogView")]
    partial class DatePickerDialogView
    {
        [Outlet]
        UIKit.UITextField TextField { get; set; }


        [Action ("ButtonPressed:")]
        partial void ButtonPressed (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (TextField != null) {
                TextField.Dispose ();
                TextField = null;
            }
        }
    }
}