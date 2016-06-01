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
        private string readingsButtonLabel;
		private string tresholdButtonLabel;

		public ObservableCollection<ChartDataPoint> Batch3 { get; set; }

        public string ReadingsButtonLabel
        {
            get { return readingsButtonLabel; }
            set { readingsButtonLabel = value; }
        }

		public string TresholdButtonLabel {
			get { return tresholdButtonLabel; }
			set { tresholdButtonLabel = value; }
		}

		public ICommand TresholdButtonCommand { get; private set;}

        public ICommand ReadingsButtonCommand { get; private set; }

        public OverviewViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

			// Set readings button
            ReadingsButtonLabel = "Readings";
            ReadingsButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.Readings));

			// Set treshhold button
			TresholdButtonLabel = "Treshold";
			TresholdButtonCommand = new Command(() =>
			_navigationservice.NavigateTo (Locator.Thresholds));

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
