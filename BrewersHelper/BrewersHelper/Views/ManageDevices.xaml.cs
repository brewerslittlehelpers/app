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

			//this.BindingContext = new [] { "a", "b", "c" };
			BindingContext = new ManageDevicesViewModel();
		}

		void OnItemTapped (object sender, ItemTappedEventArgs e) {
			if (e == null) return; // has been set to null, do not 'process' tapped event
			Debug.WriteLine("Tapped: " + e.Item);
			((ListView)sender).SelectedItem = null; // de-select the row
		}

		public void OnDelete (object sender, EventArgs e) {

			/*var item = (Xamarin.Forms.Button)sender;  
			Item listitem = (from itm in allItems 
				where itm.ItemName == item.CommandParameter.ToString() 
				select itm)
				.FirstOrDefault<Item>();  
			allItems.Remove(listitem);*/

			//var mi = ((MenuItem)sender);
			//DisplayAlert("Delete Helper", "Are you sure you want to delete " + mi.CommandParameter, "YES", "NO");
		}
			

		//	async void deleteHelper(object sender, EventArgs args) {
		//		await DisplayAlert("Delete", "Are you sure you want to delete helper x?", "Yes", "Ofc not!");
		//	}
	}
}




		/*	InitializeComponent();
		/*	BindingContext = new ManageDevicesViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
		}

		async void addNewHelperButton(object sender, EventArgs args) {
			await DisplayAlert ("Add helper", "Hold new helper agains screen", "Cancel");
		}
	}
}
*/