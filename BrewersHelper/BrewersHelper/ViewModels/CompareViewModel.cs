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
    class CompareViewModel : ViewModelBase
    {
        private string _brewOne;
        private string _brewTwo;
        private string _chartTitle;
        private string _primaryAxisTitle;
        private string _secondaryAxisTitle;

        public string SecondaryAxisTitle
        {
            get { return _secondaryAxisTitle; }
            set { _secondaryAxisTitle = value; RaisePropertyChanged(() => SecondaryAxisTitle); }
        }

        public string PrimaryAxisTitle
        {
            get { return _primaryAxisTitle; }
            set { _primaryAxisTitle = value; RaisePropertyChanged(() => PrimaryAxisTitle); }
        }

        public string ChartTitle
        {
            get { return _chartTitle; }
            set { _chartTitle = value; RaisePropertyChanged(() => ChartTitle); }
        }

        public string BrewOne
        {
            get { return _brewOne; }
            set { _brewOne = value; RaisePropertyChanged(() => BrewOne); }
        }

        public string BrewTwo
        {
            get { return _brewTwo; }
            set { _brewTwo = value; RaisePropertyChanged(() => BrewTwo); }
        }

        public ObservableCollection<ChartDataPoint> Batch3 { get; private set; }
        public ObservableCollection<ChartDataPoint> Batch5 { get; private set; }

        public CompareViewModel(INavigationService navigationService)
        {
            ChartTitle = "Brew Comparison";
            PrimaryAxisTitle = "Days";
            SecondaryAxisTitle = "Specific Gravity";
            BrewOne = "Tims Pale Batch 3";
            BrewTwo = "Tims Pale Batch 5";

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
