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

		public ObservableCollection<ChartDataPoint> AlcoholGraph { get; set; }
		public ObservableCollection<ChartDataPoint> PHGraph { get; set; }
		public ObservableCollection<ChartDataPoint> GravityGraph { get; set; }
		public ObservableCollection<ChartDataPoint> TemperatureGraph { get; set; }

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

			List<SampleModel> samples = App.Database.GetSamples().ToList();

			double alcoholReading = samples.Last().Alcohol;


			// hacky way of doing this
			int currentBatch = 1;
			List<SampleModel> currentBatchSamples = new List<SampleModel>();

			foreach (SampleModel s in samples)
			{
				if (s.O2MBatchKey == currentBatch) {
					currentBatchSamples.Add (s);
				}
			}

			AlcoholGraph = new ObservableCollection<ChartDataPoint>();
			PHGraph = new ObservableCollection<ChartDataPoint>();
			GravityGraph = new ObservableCollection<ChartDataPoint>();
			TemperatureGraph = new ObservableCollection<ChartDataPoint>();


			foreach (SampleModel s in currentBatchSamples){
				AlcoholGraph.Add (new ChartDataPoint(s.Time, s.Alcohol));
				PHGraph.Add (new ChartDataPoint(s.Time, s.PH));
				GravityGraph.Add (new ChartDataPoint(s.Time, s.Gravity));
				TemperatureGraph.Add (new ChartDataPoint(s.Time, s.Temp));
			}

			SampleModel lastSampleFromBatch = currentBatchSamples.Last ();

			AlcoholReadingLabel = String.Format("{0}%", lastSampleFromBatch.Alcohol);
			GravityReadingLabel = String.Format("{0}", lastSampleFromBatch.Gravity);
			TemperatureReadingLabel = String.Format("{0}°C", lastSampleFromBatch.Temp);
			PHReadingLabel = String.Format("{0}", lastSampleFromBatch.PH);
        }
    }
}
