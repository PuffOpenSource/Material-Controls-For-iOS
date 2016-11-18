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
    [Register ("SwitchView")]
    partial class SwitchView
    {
        [Outlet]
        MaterialControls.MDSwitch CustomSwitch { get; set; }


        [Outlet]
        UIKit.UILabel CustomSwitchStatus { get; set; }


        [Outlet]
        MaterialControls.MDSwitch DefaultSwitch { get; set; }


        [Outlet]
        UIKit.UILabel DefaultSwitchStatus { get; set; }


        [Outlet]
        MaterialControls.MDSwitch DisabledSwitch { get; set; }


        [Outlet]
        UIKit.UILabel DisabledSwitchStatus { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CustomSwitchStatus != null) {
                CustomSwitchStatus.Dispose ();
                CustomSwitchStatus = null;
            }

            if (DefaultSwitchStatus != null) {
                DefaultSwitchStatus.Dispose ();
                DefaultSwitchStatus = null;
            }

            if (DisabledSwitchStatus != null) {
                DisabledSwitchStatus.Dispose ();
                DisabledSwitchStatus = null;
            }
        }
    }
}