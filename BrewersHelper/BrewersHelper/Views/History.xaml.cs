using BrewersHelper.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BrewersHelper.Views
{
    public partial class History : ContentPage
    {
        public History()
        {
            InitializeComponent();
            BindingContext = new HistoryViewModel(SimpleIoc.Default.GetInstance<INavigationService>());
        }
    }
}
