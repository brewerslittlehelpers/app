using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace BrewersHelper
{
	public partial class HelperPage : ContentPage
	{
		public HelperPage ()
		{
			InitializeComponent ();

			//this.BindingContext = new [] { "a", "b", "c" };
			BindingContext = new HelperPageViewModel();
		}

		void OnItemTapped (object sender, ItemTappedEventArgs e) {
			if (e == null) return; // has been set to null, do not 'process' tapped event
			Debug.WriteLine("Tapped: " + e.Item);
			((ListView)sender).SelectedItem = null; // de-select the row
		}

		public void OnDelete (object sender, EventArgs e) {
			var mi = ((MenuItem)sender);
			DisplayAlert("Delete Helper", "Are you sure you want to delete " + mi.CommandParameter, "YES", "NO");
		}

	//	async void deleteHelper(object sender, EventArgs args) {
	//		await DisplayAlert("Delete", "Are you sure you want to delete helper x?", "Yes", "Ofc not!");
	//	}
	}
}

