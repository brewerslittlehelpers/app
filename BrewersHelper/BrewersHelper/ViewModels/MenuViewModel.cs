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
        private string overviewButtonLabel;
        private string historyButtonLabel;
        private string thresholdsButtonLabel;
        private string manageDevicesButtonLabel;

        public string ManageDevicesButtonLabel
        {
            get { return manageDevicesButtonLabel; }
            set
            {
                manageDevicesButtonLabel = value;
                RaisePropertyChanged(() => ManageDevicesButtonLabel);
            }
        }

        public string ThresholdsButtonLabel
        {
            get { return thresholdsButtonLabel; }
            set
            {
                thresholdsButtonLabel = value;
                RaisePropertyChanged(() => ThresholdsButtonLabel);
            }
        }

        public string HistoryButtonLabel
        {
            get { return historyButtonLabel; }
            set
            {
                historyButtonLabel = value;
                RaisePropertyChanged(() => HistoryButtonLabel);
            }
        }

        public string OverviewButtonLabel
        {
            get { return overviewButtonLabel; }
            set
            {
                overviewButtonLabel = value;
                RaisePropertyChanged(() => OverviewButtonLabel);
            }
        }

        public ICommand OverviewButtonCommand { get; private set; }
        public ICommand HistoryButtonCommand { get; private set; }
        public ICommand ThresholdsButtonCommand { get; private set; }
        public ICommand ManageDevicesButtonCommand { get; private set; }

        public MenuViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

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
