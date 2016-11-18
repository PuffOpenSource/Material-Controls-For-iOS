
using System;

using Foundation;
using UIKit;
using System.Diagnostics;
using MaterialControls.Xamarin.Sample.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	public partial class TextFieldView : BaseView<TextFieldViewModel>
	{
		public TextFieldView () : base ("TextFieldView", null)
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
			Title = "MDTextField";
			var set = this.CreateBindingSet<TextFieldView, TextFieldViewModel> ();
			set.Bind (TextField).For (tf => tf.Text).To (vm => vm.Text);
			set.Bind (LimitedLengthTextField).For (tf => tf.Text).To (vm => vm.Text);
			set.Bind (MultiLineTextField).For (tf => tf.Text).To (vm => vm.Text);
			set.Apply ();
			TextField.SingleLine = true;
			MultiLineTextField.SingleLine = true;
//			var tap = new UITapGestureRecognizer { CancelsTouchesInView = false };
//			tap.AddTarget (
//				() => {
//					TextField.ResignFirstResponder();
//					LimitedLengthTextField.ResignFirstResponder();
//					MultiLineTextField.ResignFirstResponder();
//				});
//			View.AddGestureRecognizer (tap);
		}
	}
}

