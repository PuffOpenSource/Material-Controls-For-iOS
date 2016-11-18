using System;

namespace MaterialControls.Xamarin.Sample.Core.ViewModels
{
	public class TextFieldViewModel:BaseViewModel
	{
		public TextFieldViewModel ()
		{
			
		}

		string text = "Sample Text";
		public string Text 
		{
			get { return text;}
			set 
			{
				SetProperty (ref text, value, () => Text);
			}
		}
	}
}

