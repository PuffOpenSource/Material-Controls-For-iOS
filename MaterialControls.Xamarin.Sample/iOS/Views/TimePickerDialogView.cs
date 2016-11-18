
using System;

using Foundation;
using UIKit;
using MaterialControls;
using MaterialControls.Xamarin.Sample.Core.ViewModels;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	public partial class TimePickerDialogView : BaseView<TimePickerDialogViewModel>
	{

		MDTimePickerDialog TimePickerDialog;

		public TimePickerDialogView () : base ("TimePickerDialogView", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void ButtonClicked (NSObject sender)
		{
			if(TimePickerDialog ==null) {
				TimePickerDialog = new MDTimePickerDialog();
				TimePickerDialog.Delegate = new TimePickerDelegate(TimeTextField);
			}
			TimePickerDialog.Show();

		}
	}

	public class TimePickerDelegate:MDTimePickerDialogDelegate {
		public UITextField TextField;
		public TimePickerDelegate(UITextField textField) {
			TextField = textField;
		}

		#region implemented abstract members of MDTimePickerDialogDelegate

		public override void DidSelectHour (MDTimePickerDialog timePickerDialog, nint hour, nint minute)
		{
			TextField.Text = hour + ":" + minute;
		}

		#endregion
	}
}

