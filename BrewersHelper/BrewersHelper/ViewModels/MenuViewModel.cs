using BrewersHelper.Implementations;
using BrewersHelper.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BrewersHelper.ViewModels
{
    class MenuViewModel : ViewModelBase
    {
        INavigationService _navigationservice;
        private string _overviewButtonLabel;
        private string _historyButtonLabel;
        private string _thresholdsButtonLabel;
        private string _manageDevicesButtonLabel;
        private string _specificGravityDialLabel;
        private string _currentBatchLabel;
        private string _tempDialLabel;
        private string _alcoholDialLabel;

        public string AlcoholDialLabel
        {
            get { return _alcoholDialLabel; }
            set { _alcoholDialLabel = value; }
        }

        public string TempDialLabel
        {
            get { return _tempDialLabel; }
            set { _tempDialLabel = value; }
        }

        public string CurrentBatchLabel
        {
            get { return _currentBatchLabel; }
            set { _currentBatchLabel = value; }
        }

        public string SpecificGravityDialLabel
        {
            get { return _specificGravityDialLabel; }
            set { _specificGravityDialLabel = value; }
        }

        public string ManageDevicesButtonLabel
        {
            get { return _manageDevicesButtonLabel; }
            set { _manageDevicesButtonLabel = value; }
        }

        public string ThresholdsButtonLabel
        {
            get { return _thresholdsButtonLabel; }
            set { _thresholdsButtonLabel = value; }
        }

        public string HistoryButtonLabel
        {
            get { return _historyButtonLabel; }
            set { _historyButtonLabel = value; }
        }

        public string OverviewButtonLabel
        {
            get { return _overviewButtonLabel; }
            set { _overviewButtonLabel = value; }
        }

        public ICommand OverviewButtonCommand { get; private set; }
        public ICommand HistoryButtonCommand { get; private set; }
        public ICommand ThresholdsButtonCommand { get; private set; }
        public ICommand ManageDevicesButtonCommand { get; private set; }

        public MenuViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            CurrentBatchLabel = "Tims Pale Ale, Batch 3";
            SpecificGravityDialLabel = "Specific Gravity";
            TempDialLabel = "Temperature";
            AlcoholDialLabel = "Alcohol";

            OverviewButtonLabel = "Overview";
            OverviewButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.Overview));

            ThresholdsButtonLabel = "Thresholds";
            ThresholdsButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.Thresholds));

            ManageDevicesButtonLabel = "Manage Devices";
            ManageDevicesButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.ManageDevices));

            HistoryButtonLabel = "History";
            HistoryButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.History));
        }
    }
}
