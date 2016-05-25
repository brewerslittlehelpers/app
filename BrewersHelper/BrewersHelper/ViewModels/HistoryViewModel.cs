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
    class HistoryViewModel : ViewModelBase
    {
        INavigationService _navigationservice;
        private string compareButtonLabel;

        public string CompareButtonLabel
        {
            get { return compareButtonLabel; }
            set { compareButtonLabel = value; }
        }

        public ICommand CompareButtonCommand { get; private set; }

        public HistoryViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;

            CompareButtonLabel = "Compare";
            CompareButtonCommand = new Command(() =>
            _navigationservice.NavigateTo(Locator.Compare));
        }
    }
}
