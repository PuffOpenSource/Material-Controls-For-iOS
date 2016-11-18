using System;
using System.Linq.Expressions;
using MvvmCross.Core.ViewModels;

namespace MaterialControls.Xamarin.Sample.Core.ViewModels
{
	public class BaseViewModel:MvxViewModel
	{
		public BaseViewModel ()
		{
		}

		protected void SetProperty<T>(ref T currentValue, T newValue, Expression<Func<T>> property)
		{
			if (!object.Equals(currentValue, newValue))
			{
				currentValue = newValue;
				RaisePropertyChanged(property);
			}
		}
	}
}

