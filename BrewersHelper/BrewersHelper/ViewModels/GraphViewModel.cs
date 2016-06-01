using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Syncfusion.SfChart.XForms;

namespace BrewersHelper.ViewModels
{
	class GraphViewModel : ViewModelBase
	{

		public ObservableCollection<ChartDataPoint> Batch3 { get; set; }
		public ObservableCollection<ChartDataPoint> Batch5 { get; set; }

		public GraphViewModel(INavigationService navigationService)
		{
			
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

			Batch5 = new ObservableCollection<ChartDataPoint>();
			Batch5.Add(new ChartDataPoint("1", 1.054));
			Batch5.Add(new ChartDataPoint("2", 1.052));
			Batch5.Add(new ChartDataPoint("3", 1.051));
			Batch5.Add(new ChartDataPoint("4", 1.047));
			Batch5.Add(new ChartDataPoint("5", 1.035));
			Batch5.Add(new ChartDataPoint("6", 1.023));
			Batch5.Add(new ChartDataPoint("7", 1.018));
			Batch5.Add(new ChartDataPoint("8", 1.012));
			Batch5.Add(new ChartDataPoint("9", 1.010));
			Batch5.Add(new ChartDataPoint("10", 1.010));
			Batch5.Add(new ChartDataPoint("11", 1.009));
			Batch5.Add(new ChartDataPoint("12", 1.009));
		}
	}
}
