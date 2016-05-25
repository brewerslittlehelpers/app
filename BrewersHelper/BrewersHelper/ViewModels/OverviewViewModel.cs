using BrewersHelper.Implementations;
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
    class OverviewViewModel : ViewModelBase
    {
        INavigationService _navigationservice;
        private string readingsButtonLabel;

        public string ReadingsButtonLabel
        {
            get { return readingsButtonLabel; }
            set { readingsButtonLabel = value; }
        }

        public ICommand ReadingsButtonCommand { get; private set; }

        public OverviewViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            ReadingsButtonLabel = "Readings";
            ReadingsButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.Readings));
        }
    }
}
