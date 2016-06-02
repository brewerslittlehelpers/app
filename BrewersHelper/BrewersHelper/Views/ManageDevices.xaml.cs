using BrewersHelper.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;

namespace BrewersHelper.Views
{
	public partial class ManageDevices : ContentPage
	{
		public ManageDevices()
		{
			InitializeComponent ();
			BindingContext = new ManageDevicesViewModel();
		}
	}
}




/*	InitializeComponent();
		/*	InitializeComponent();
		/*	BindingContext = new ManageDevicesViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
		}

		async void addNewHelperButton(object sender, EventArgs args) {
			await DisplayAlert ("Add helper", "Hold new helper agains screen", "Cancel");
		}
	}
}
*/