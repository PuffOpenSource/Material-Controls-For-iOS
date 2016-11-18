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
    [Register ("TextFieldView")]
    partial class TextFieldView
    {
        [Outlet]
        MaterialControls.MDTextField LimitedLengthTextField { get; set; }


        [Outlet]
        MaterialControls.MDTextField MultiLineTextField { get; set; }


        [Outlet]
        UIKit.UITextField TestText { get; set; }


        [Outlet]
        MaterialControls.MDTextField TextField { get; set; }


        [Action ("change:")]
        partial void change (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
        }
    }
}