using BrewersHelper.Implementations;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Syncfusion.SfChart.XForms;

namespace BrewersHelper.ViewModels
{
    class OverviewViewModel : ViewModelBase
    {
        INavigationService _navigationservice;

		// Labels

		public string TresholdButtonLabel { get; private set; }

		public string AlcoholReadingLabel { get; private set; }
		public string TemperatureReadingLabel { get; private set; }
		public string GravityReadingLabel { get; private set; }
		public string PHReadingLabel { get; private set; }

		// Temp collections

		public ObservableCollection<ChartDataPoint> Batch3 { get; set; }

		// Commands

		public ICommand TresholdButtonCommand { get; private set;}

        public OverviewViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

			// Set treshhold button
			TresholdButtonLabel = "Treshold";
			TresholdButtonCommand = new Command(() =>
			_navigationservice.NavigateTo (Locator.Thresholds));


			// Reading labels
			// TODO get from database

			AlcoholReadingLabel = "4%";
			GravityReadingLabel = "1.022";
			TemperatureReadingLabel = "17°C";
			PHReadingLabel = "4.2";

			Batch3 = new ObservableCollection<ChartDataPoint>();
			Batch3.Add(new ChartDataPoint("1", 1.054));
			Batch3.Add(new ChartDataPoint("2", 1.053));
			Batch3.Add(new ChartDataPoint("3", 1.048));
			Batch3.Add(new ChartDataPoint("4", 1.041));
			Batch3.Add(new ChartDataPoint("5", 1.032));
			Batch3.Add(new ChartDataPoint("6", 1.021));
			Batch3.Add(new ChartDataPoint("7", 1.018));
			Batch3.Add(new ChartDataPoint("8", 1.015));
			Batch3.Add(new ChartDataPoint("9", 1.011));
			Batch3.Add(new ChartDataPoint("10", 1.010));
			Batch3.Add(new ChartDataPoint("11", 1.010));
			Batch3.Add(new ChartDataPoint("12", 1.010));
			Batch3.Add(new ChartDataPoint("", 1.010));

        }
    }
}
