using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Testing
{	
	public partial class P6SetTimer : ContentPage
	{
		private TapGestureRecognizer tapGestureRecognizerBellProcessDuration     = new TapGestureRecognizer();
		private TapGestureRecognizer tapGestureRecognizerBellThreholdTemperature = new TapGestureRecognizer();
		private TapGestureRecognizer tapGestureRecognizerBellThreholdGravity     = new TapGestureRecognizer();
		private TapGestureRecognizer tapGestureRecognizerBellThreholdAlcohol     = new TapGestureRecognizer();

		private TapGestureRecognizer tapGestureRecognizerIconHistory     = new TapGestureRecognizer();
		private TapGestureRecognizer tapGestureRecognizerIconTemperature = new TapGestureRecognizer();
		private TapGestureRecognizer tapGestureRecognizerIconGravity     = new TapGestureRecognizer();
		private TapGestureRecognizer tapGestureRecognizerIconAlcohol     = new TapGestureRecognizer();

		public P6SetTimer ()
		{
			InitializeComponent ();

			sliderDuration.ValueChanged += HandleValueChangedDuration;
			sliderTemperature.ValueChanged += HandleValueChangedTemperature;
			sliderGravity.ValueChanged += HandleValueChangedGravity;
			sliderAlcohol.ValueChanged += HandleValueChangedAlcohol;
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			tapGestureRecognizerBellProcessDuration.Tapped += OnBellProcessDurationTapped;
			imgBellProcessDuration.GestureRecognizers.Add(tapGestureRecognizerBellProcessDuration);

			tapGestureRecognizerBellThreholdTemperature.Tapped += OnBellThreholdTemperatureTapped;
			imgBellThreholdTemperature.GestureRecognizers.Add(tapGestureRecognizerBellThreholdTemperature);

			tapGestureRecognizerBellThreholdGravity.Tapped += OnBellThreholdGravityTapped;
			imgBellThreholdGravity.GestureRecognizers.Add(tapGestureRecognizerBellThreholdGravity);

			tapGestureRecognizerBellThreholdAlcohol.Tapped += OnBellThreholdAlcoholTapped;
			imgBellThreholdAlcohol.GestureRecognizers.Add(tapGestureRecognizerBellThreholdAlcohol);

			tapGestureRecognizerIconHistory.Tapped += OnIconHistoryTapped;
			imgIconHistory.GestureRecognizers.Add (tapGestureRecognizerIconHistory);

			tapGestureRecognizerIconTemperature.Tapped += OnIconTemperatureTapped;
			imgIconTemperature.GestureRecognizers.Add (tapGestureRecognizerIconTemperature);

			tapGestureRecognizerIconGravity.Tapped += OnIconGravityTapped;
			imgIconGravity.GestureRecognizers.Add (tapGestureRecognizerIconGravity);

			tapGestureRecognizerIconAlcohol.Tapped += OnIconAlcoholTapped;
			imgIconAlcohol.GestureRecognizers.Add (tapGestureRecognizerIconAlcohol);
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();

			tapGestureRecognizerBellProcessDuration.Tapped -= OnBellProcessDurationTapped;
			imgBellProcessDuration.GestureRecognizers.Remove(tapGestureRecognizerBellProcessDuration);

			tapGestureRecognizerBellThreholdTemperature.Tapped -= OnBellThreholdTemperatureTapped;
			imgBellThreholdTemperature.GestureRecognizers.Remove(tapGestureRecognizerBellThreholdTemperature);

			tapGestureRecognizerBellThreholdGravity.Tapped -= OnBellThreholdGravityTapped;
			imgBellThreholdGravity.GestureRecognizers.Remove(tapGestureRecognizerBellThreholdGravity);

			tapGestureRecognizerBellThreholdAlcohol.Tapped -= OnBellThreholdAlcoholTapped;
			imgBellThreholdAlcohol.GestureRecognizers.Remove(tapGestureRecognizerBellThreholdAlcohol);

			tapGestureRecognizerIconHistory.Tapped -= OnIconHistoryTapped;
			imgIconHistory.GestureRecognizers.Remove (tapGestureRecognizerIconHistory);

			tapGestureRecognizerIconTemperature.Tapped -= OnIconTemperatureTapped;
			imgIconTemperature.GestureRecognizers.Remove (tapGestureRecognizerIconTemperature);

			tapGestureRecognizerIconGravity.Tapped -= OnIconGravityTapped;
			imgIconGravity.GestureRecognizers.Remove (tapGestureRecognizerIconGravity);

			tapGestureRecognizerIconAlcohol.Tapped -= OnIconAlcoholTapped;
			imgIconAlcohol.GestureRecognizers.Remove (tapGestureRecognizerIconAlcohol);
		}

		public void OnBellProcessDurationTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an Process Duration", "OK"); 
		}

		public void OnBellThreholdTemperatureTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an Threhold Temperature", "OK"); 
		}

		public void OnBellThreholdGravityTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an Threhold Gravity", "OK"); 
		}

		public void OnBellThreholdAlcoholTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an Threhold Alcohol", "OK"); 
		}

		public void OnIconHistoryTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an History Icon", "OK"); 
		}

		public void OnIconTemperatureTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an Temperature Icon", "OK"); 
		}

		public void OnIconGravityTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an Gravity Icon", "OK"); 
		}

		public void OnIconAlcoholTapped(object sender, EventArgs e)
		{
			// handle the tap  
			DisplayAlert("Alert", "This is an Alcohol Icon", "OK"); 
		}

		void OnResetButtonClicked(object sender, EventArgs args)
		{
			// handle the click  
			DisplayAlert("Alert", "This is an Reset Button", "OK"); 
		}

		void OnApplySaveButtonClicked(object sender, EventArgs args)
		{
			// handle the click  
			DisplayAlert("Alert", "This is an Apply & Save Button", "OK"); 
		}

		void HandleValueChangedDuration (object sender, EventArgs e)
		{   // display the value in a label
			int nValue = (int) sliderDuration.Value;
			lblDuration.Text = nValue.ToString () + " Min";
		}

		void HandleValueChangedTemperature (object sender, EventArgs e)
		{   // display the value in a label
			int nValue = (int) sliderTemperature.Value;
			lblTemperature.Text = nValue.ToString () + " °C";
		}

		void HandleValueChangedGravity (object sender, EventArgs e)
		{   // display the value in a label
			lblGravity.Text = sliderGravity.Value.ToString("0.000");
		}

		void HandleValueChangedAlcohol (object sender, EventArgs e)
		{   // display the value in a label
			lblAlcohol.Text = sliderAlcohol.Value.ToString ("0.0") + " %";
		}

	}
}

