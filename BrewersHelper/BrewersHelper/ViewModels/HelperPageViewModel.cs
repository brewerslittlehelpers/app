using BrewersHelper.Implementations;
using BrewersHelper.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace BrewersHelper
{
	public class HelperPageViewModel : ViewModelBase
	{

		public ObservableCollection<string> helperList{ get; private set; }
		private string addHelperLabel;

		public string AddHelperLabel {
			get { return addHelperLabel; }
			set { addHelperLabel = value; }
		}

		public ICommand DeleteHelperCommand{ get; private set; }
		public ICommand AddHelperCommand{ get; private set; }

		public HelperPageViewModel ()
		{
			helperList = new ObservableCollection<string> { "one", "two", "three", "Four", "Five" };
			AddHelperLabel = "Add new helper";

			DeleteHelperCommand = new Command (() =>
				App.Current.MainPage.DisplayAlert ("Delete", "Are you sure you want to delete helper?", "Yes", "No"));
			AddHelperCommand = new Command (() =>
				App.Current.MainPage.DisplayAlert("Add helper", "Hold new helper close to the screen", "Cancel"));
			
		}
	}
}

