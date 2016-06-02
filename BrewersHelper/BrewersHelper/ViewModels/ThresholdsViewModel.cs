using BrewersHelper.Implementations;
using BrewersHelper.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace BrewersHelper.ViewModels
{
    class ThresholdsViewModel : INotifyPropertyChanged
    {
        Thresholds _thresholds;
        double processDurationValue, thresholdTemperatureValue, gravityValue, alcoholValue;
        bool isDialogShown;
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsDialogShown
        {
            set
            {
                if (isDialogShown != value)
                {
                    isDialogShown = value;
                    OnPropertyChanged("IsDialogShown");
                }
            }
            get
            {
                return isDialogShown;
            }
        }

        public double ProcessDurationValue
        {
            set
            {
                if (processDurationValue != value)
                {
                    processDurationValue = value;
                    OnPropertyChanged("ProcessDurationValue");
                }
            }
            get
            {
                return processDurationValue;
            }
        }

        public double ThresholdTemperatureValue
        {
            set
            {
                if (thresholdTemperatureValue != value)
                {
                    thresholdTemperatureValue = value;
                    OnPropertyChanged("ThresholdTemperatureValue");
                }
            }
            get
            {
                return thresholdTemperatureValue;
            }
        }

        public double GravityValue
        {
            set
            {
                if (gravityValue != value)
                {
                    gravityValue = value;
                    OnPropertyChanged("GravityValue");
                }
            }
            get
            {
                return gravityValue;
            }
        }

        public double AlcoholValue
        {
            set
            {
                if (alcoholValue != value)
                {
                    alcoholValue = value;
                    OnPropertyChanged("AlcoholValue");
                }
            }
            get
            {
                return alcoholValue;
            }
        }

        private ObservableCollection<string> _myCollection;
        public ObservableCollection<string> myCollection
        {
            get
            {
                return _myCollection;
            }
            set
            {
                _myCollection = value;
                OnPropertyChanged("myCollection");
            }
        }



        private string _myitem;
        public string myItem
        {
            get
            {
                return _myitem;
            }
            set
            {
                _myitem = value;
                OnPropertyChanged("myItem");
            }
        }

        public ICommand ResetButtonCommand { get; private set; }
        public ICommand ApplyButtonCommand { get; private set; }
        public ICommand TapBellProcessDuration { get; private set; }
        public ICommand TapBellTemperature { get; private set; }
        public ICommand TapBellGravity { get; private set; }
        public ICommand TapBellAlcohol { get; private set; }
        public ICommand PopupAddButtonCommand { get; private set; }
        public ICommand PopupApplyButtonCommand { get; private set; }

        public ThresholdsViewModel(Thresholds thresholds)
        {
            _thresholds = thresholds;

            ProcessDurationValue = 65;
            ThresholdTemperatureValue = 65;
            GravityValue = 1.045;
            AlcoholValue = 4.8;
            IsDialogShown = false;
            myCollection = new ObservableCollection<string> {
                "10%", "20%"
            };

            ResetButtonCommand = new Command(() => _thresholds.DisplayAlert("Alert", "This is an Reset Button", "OK"));
            ApplyButtonCommand = new Command(() => _thresholds.DisplayAlert("Alert", "This is an Apply Button", "OK"));
            TapBellProcessDuration = new Command(() => IsDialogShown = true);
            TapBellTemperature = new Command(() => _thresholds.DisplayAlert("Alert", "This is an Temperature", "OK"));
            TapBellGravity = new Command(() => _thresholds.DisplayAlert("Alert", "This is an Gravity", "OK"));
            TapBellAlcohol = new Command(() => _thresholds.DisplayAlert("Alert", "This is an Alcohol", "OK"));
            PopupAddButtonCommand = new Command(() => IsDialogShown = false);
            PopupApplyButtonCommand = new Command(() => IsDialogShown = false);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

