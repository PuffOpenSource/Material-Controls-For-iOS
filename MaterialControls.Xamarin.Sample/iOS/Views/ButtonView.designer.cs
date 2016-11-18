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
    [Register ("ButtonView")]
    partial class ButtonView
    {
        [Outlet]
        MaterialControls.MDButton FlatButton { get; set; }


        [Outlet]
        MaterialControls.MDButton FloatingActionButton { get; set; }


        [Outlet]
        UIKit.UILabel Label { get; set; }


        [Outlet]
        MaterialControls.MDButton RaisedButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Label != null) {
                Label.Dispose ();
                Label = null;
            }
        }
    }
}