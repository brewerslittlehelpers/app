﻿using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace BrewersHelper
{
	public class HelperList : ContentPage
	{
		public HelperList ()
		{
			//var listView = new ListView ();

			//listView.ItemsSource = new [] { "Helper 1", "Helper 2", "Helper 3" };

			// Using ItemTapped
		/*	listView.ItemTapped += async (sender, e) => {
				await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");
				Debug.WriteLine("Tapped: " + e.Item);
				((ListView)sender).SelectedItem = null; // de-select the row
			};*/

			// If using ItemSelected
			//			listView.ItemSelected += (sender, e) => {
			//				if (e.SelectedItem == null) return;
			//				Debug.WriteLine("Selected: " + e.SelectedItem);
			//				((ListView)sender).SelectedItem = null; // de-select the row
			//			};

			//Padding = new Thickness (0,20,0,0);
			//Content = listView;
		}
	}
}

