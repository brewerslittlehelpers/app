﻿using BrewersHelper.Implementations;
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


namespace BrewersHelper.ViewModels
{
	class ManageDevicesViewModel : ViewModelBase
	{

		public ObservableCollection<Helper> helperList{ get; private set; }
		public ObservableCollection<string> progressPercent{ get; private set; }
		private string addHelperLabel;

		public string AddHelperLabel {
			get { return addHelperLabel; }
			set { addHelperLabel = value; }
		}

		public ICommand DeleteHelperCommand{ get; private set; }
		public ICommand AddHelperCommand{ get; private set; }

		public ManageDevicesViewModel ()
		{
			helperList = new ObservableCollection<Helper> ();// { "Helper 1", "Helper 2", "Helper 3", "Helper 4", "Helper 5" };
			Helper helper1 = new Helper("Helper 1", 0.3, "30%");
			Helper helper2 = new Helper ("Helper 2", 0.9, "90%");
			helperList.Add (helper1);
			helperList.Add (helper2);
			//progressPercent = new ObservableCollection<string> { "0.1", "0.8", "0.3", "0.9", "1.0" };
			AddHelperLabel = "Add new helper";

			DeleteHelperCommand = new Command (() =>
				//helperList.RemoveAt(0));
				App.Current.MainPage.DisplayAlert ("Delete", "Are you sure you want to delete helper?", "Yes", "No"));
			AddHelperCommand = new Command (() =>
				helperList.Add(new Helper("Helper " + (helperList.Count + 1).ToString(), 1.0, "100%")));
				//App.Current.MainPage.DisplayAlert("Add helper", "Hold new helper close to the screen", "Cancel"));
		}
	}
}



		/*INavigationService _navigationservice;

	/*	private string helperPageLabel;

		public string HelperPageLabel
		{
			get { return helperPageLabel; }
			set
			{
				helperPageLabel = value;
				RaisePropertyChanged(() => HelperPageLabel);
			}
		}

		public ICommand HelperPageCommand{ get; private set; }
		public ICommand AddHelperCommand{ get; private set; }

		public ManageDevicesViewModel(INavigationService navigationservice)
		{
			_navigationservice = navigationservice;

			HelperPageLabel = "Go to helper";
			HelperPageCommand = new Command(() =>
				_navigationservice.NavigateTo(Locator.HelperPage));

			AddHelperCommand = new Command(() =>
				App.Current.MainPage.DisplayAlert("Add helper", "Hold helper agains screen", "Cancel"));

		}
	}
}
*/