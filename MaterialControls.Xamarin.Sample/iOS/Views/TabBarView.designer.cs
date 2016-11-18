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
    [Register ("TabBarView")]
    partial class TabBarView
    {
        [Outlet]
        MaterialControls.MDSwitch AnimatedSwitch { get; set; }


        [Outlet]
        UIKit.UITextField IndexTextField { get; set; }


        [Outlet]
        UIKit.UITextField LabelTextField { get; set; }


        [Outlet]
        UIKit.UILabel SelectedIndexLabel { get; set; }


        [Outlet]
        MaterialControls.MDTabBar TabBar { get; set; }


        [Action ("AddClicked:")]
        partial void AddClicked (Foundation.NSObject sender);


        [Action ("RemoveClicked:")]
        partial void RemoveClicked (Foundation.NSObject sender);


        [Action ("RenameClicked:")]
        partial void RenameClicked (Foundation.NSObject sender);


        [Action ("ReplaceClicked:")]
        partial void ReplaceClicked (Foundation.NSObject sender);


        [Action ("SelectClicked:")]
        partial void SelectClicked (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (IndexTextField != null) {
                IndexTextField.Dispose ();
                IndexTextField = null;
            }

            if (LabelTextField != null) {
                LabelTextField.Dispose ();
                LabelTextField = null;
            }

            if (SelectedIndexLabel != null) {
                SelectedIndexLabel.Dispose ();
                SelectedIndexLabel = null;
            }
        }
    }
}