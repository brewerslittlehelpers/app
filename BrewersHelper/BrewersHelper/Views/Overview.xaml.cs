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
    public partial class Overview : ContentPage
    {
        public Overview()
        {
            InitializeComponent();
            BindingContext = new OverviewViewModel(SimpleIoc.Default.GetInstance<INavigationService>());

			this.Appearing += Overview_Appearing;
        }

        void Overview_Appearing (object sender, EventArgs e)
        {
			// read data from model
			AlcoholReadingLabel.Text = "35";
        }
    }
}
