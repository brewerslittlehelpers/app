using BrewersHelper.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

using Xamarin.Forms;

namespace BrewersHelper.Views
{
    public partial class Overview : ContentPage
    {
        public Overview()
        {
            InitializeComponent();
            BindingContext = new OverviewViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
    }
}
